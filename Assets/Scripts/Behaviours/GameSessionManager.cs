using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;

public class GameSessionManager : MonoBehaviour
{
    private const int PLAYER_COUNT = 2;
    private const int MAX_TURN_COUNT = 2;
   
    private int turnNumber = 0;
    private int movementsLeft = 0;

    public State state { get; private set; }
    public enum State
    {
        WaitToStart,
        Rolling,
        Moving,
        DirectionSelect,
        Waiting,
        Ended
    }

    void Start()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);

        InitializePlayers();
        InitializeGameInterface();

        MainCameraManager.Instance.ZoomToOverview();
        state = State.WaitToStart;
    }

    void Update()
    {
        if (state == State.WaitToStart)
        {
            // Start game
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameInterfaceManager.Instance.HideAnnouncementPanel();

                DiceRoller.Instance.StartRoll();
                MainCameraManager.Instance.ZoomToTarget(PlayerListManager.Instance.GetCurrentPlayer().transform.position);
                state = State.Rolling;
            }
        }
        else if (state == State.DirectionSelect)
        {
            // Select direction
            if (Input.GetKeyDown(KeyCode.Space))
            {
                state = State.Moving;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                DirectionSelectorManager.Instance.IncrementSelection(1);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                DirectionSelectorManager.Instance.IncrementSelection(1);
            }

            var currentPlayer = PlayerListManager.Instance.GetCurrentPlayer();
            DirectionSelectorManager.Instance.UpdateSelector(currentPlayer);
        }
        else if (state == State.Moving)
        {
            // If there are no movements left, stop the player and wait to end turn
            if (movementsLeft == 0)
            {
                // Grant player an orb when falling on space
                var newPos = MapManager.Instance.DirectionMap.WorldToCell(PlayerListManager.Instance.GetCurrentPlayer().transform.position);
                HexOrbTile orbTile = (HexOrbTile)MapManager.Instance.OrbMap.GetTile(newPos);
                Debug.Log("ORB TYPE: " + orbTile.orbType.ToString());

                PlayerListManager.Instance.GetCurrentPlayer().GetComponent<PlayerInfo>().AddScore(orbTile.orbType, 1);

                // Quick pause before zooming out to overview
                Thread.Sleep(500);
                MainCameraManager.Instance.ZoomToOverview();
                state = State.Waiting;
            }
            else
            {
                MoveCurrentPlayer();
            }
        }
        else if (state == State.Rolling)
        {
            // When pressed use selection and advance
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var diceValue = DiceRoller.Instance.GetValue();

                movementsLeft = diceValue;

                state = State.Moving;
            }
        }
        else if (state == State.Waiting)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // End turn, Switch User
                turnNumber++;
                PlayerListManager.Instance.EndPlayerTurn();

                DiceRoller.Instance.StartRoll();

                // Zoom in to player
                MainCameraManager.Instance.ZoomToTarget(PlayerListManager.Instance.GetCurrentPlayer().transform.position);
                state = State.Rolling;
            }
        }

        GameInterfaceManager.Instance.UpdateInterface(turnNumber/PLAYER_COUNT);

        CheckWinner();

        if (Input.GetKey(KeyCode.O))
        {
            MainCameraManager.Instance.ForceOverview();
        }
    }

    private void CheckWinner()
    {
        // Check for winner
        if (turnNumber / PLAYER_COUNT > MAX_TURN_COUNT)
        {
            state = State.Ended;

            // TODO get winner
            var highScoresList = GameInterfaceManager.Instance.GetHighScoresList();

            var allPlayers = PlayerListManager.Instance.GetAllPlayers();

            var scores = new Dictionary<GameObject, int>();

            foreach (var player in allPlayers)
            {
                scores.Add(player, 0);
            }

            foreach (var (orbType, highScoreList) in highScoresList.Select(x => (x.Key, x.Value)))
            {
                var aaa = highScoreList.GetPlayerList();

                if (
                    aaa.Count > 1 // More than 2 players have it
                    ||
                    aaa[0] == null // No player control it
                   )
                {
                    continue;
                }

                scores[aaa[0]] += 1;
            }

            GameObject winner = null;
            var highScore = 0;

            foreach (var (player, score) in scores.Select(x => (x.Key, x.Value)))
            {
                if (score > highScore)
                {
                    winner = player;
                }
            }

            if (winner == null)
            {
                GameInterfaceManager.Instance.ShowAnnouncementPanel("NO WINNER");
                MainCameraManager.Instance.ZoomToOverview();
            }
            else
            {
                GameInterfaceManager.Instance.ShowAnnouncementPanel("WINNER");
                MainCameraManager.Instance.ZoomToTarget(winner.transform.position);
            }

            // Clear the dice roller
            DiceRoller.Instance.Clear();
            GameInterfaceManager.Instance.ClearCurrentPlayer();
        }
    }

    private bool MoveCurrentPlayer()
    {
        var currentPlayer = PlayerListManager.Instance.GetCurrentPlayer();

        var gridPosition = MapManager.Instance.DirectionMap.WorldToCell(currentPlayer.transform.position);

        HexDirectionalTile directionTile = (HexDirectionalTile)MapManager.Instance.DirectionMap.GetTile(gridPosition);

        // Wait for selection if there is more than 1 direction
        int direction;
        if (directionTile.directions.Count > 1)
        {
            if (!DirectionSelectorManager.Instance.Active())
            {
                DirectionSelectorManager.Instance.StartSelection(currentPlayer);
                state = State.DirectionSelect;
                return false;
            }

            direction = DirectionSelectorManager.Instance.CompleteSelection();
        }
        else
        {
            direction = directionTile.directions[0];
        }

        var newPos = CubeCoordUtils.UnityCellToCube(gridPosition) + MapManager.DIRECTIONS[direction];

        currentPlayer.transform.position = MapManager.Instance.DirectionMap.CellToWorld(CubeCoordUtils.CubeToUnityCell(newPos));

        // Camera follow player
        MainCameraManager.Instance.ForceZoomToTarget(currentPlayer.transform.position);

        movementsLeft--;
        DiceRoller.Instance.SetValue(movementsLeft);

        // Add short wait, to make it easier to follow
        Thread.Sleep(200);

        return true;
    }

    private void InitializePlayers()
    {
        PlayerListManager.Instance.Initialize(PLAYER_COUNT, MapManager.START_POSITION);
        PlayerListManager.Instance.SetCurrentPlayerIndex(0);
    }

    private void InitializeGameInterface()
    {
        GameInterfaceManager.Instance.Initialize();
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;

public class GameSessionManager : MonoBehaviour
{
    private const int MAX_TURN_COUNT = 20;
   
    private int playerCount = 0;

    private int playerTurnsCount = 0;
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

        MainCameraManager.Instance.ZoomToOverview();
        state = State.WaitToStart;
    }

    void Update()
    {
        if (state == State.WaitToStart)
        {
            // Start game
            var key2 = Input.GetKeyDown(KeyCode.Alpha2);
            var key3 = Input.GetKeyDown(KeyCode.Alpha3);
            var key4 = Input.GetKeyDown(KeyCode.Alpha4);
            var key5 = Input.GetKeyDown(KeyCode.Alpha5);

            if (key2 || key3 || key4 || key5)
            {
                GameInterfaceManager.Instance.HideAnnouncementPanel();

                // TODO this transformation is pretty ugly
                if (key2)
                {
                    playerCount = 2;
                }
                else if (key3)
                {
                    playerCount = 3;
                }
                else if (key4)
                {
                    playerCount = 4;
                }
                else if (key5)
                {
                    playerCount = 5;
                }

                InitializePlayers(playerCount);

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
                playerTurnsCount++;
                PlayerListManager.Instance.EndPlayerTurn();

                DiceRoller.Instance.StartRoll();

                // Zoom in to player
                MainCameraManager.Instance.ZoomToTarget(PlayerListManager.Instance.GetCurrentPlayer().transform.position);
                state = State.Rolling;
            }
        }

        var gameTurn = playerTurnsCount == 0 ? 0 : playerTurnsCount / playerCount;
        GameInterfaceManager.Instance.UpdateInterface(gameTurn);

        CheckWinner();

        if (Input.GetKey(KeyCode.O))
        {
            MainCameraManager.Instance.ForceOverview();
        }
    }

    private void CheckWinner()
    {
        if (playerCount == 0)
        {
            return;
        }

        if (playerTurnsCount / playerCount > MAX_TURN_COUNT)
        {
            state = State.Ended;

            var allPlayers = PlayerListManager.Instance.GetAllPlayers();
            var highScoresList = GameInterfaceManager.Instance.GetHighScoresList();

            var scores = new Dictionary<GameObject, int>();

            foreach (var player in allPlayers)
            {
                scores.Add(player, 0);
            }

            foreach (var (orbType, highScoreList) in highScoresList.Select(x => (x.Key, x.Value)))
            {
                var typeWinner = highScoreList.GetPlayerList();

                if (
                    typeWinner.Count > 1 // More than 2 players have it
                    ||
                    typeWinner[0] == null // No player control it
                   )
                {
                    continue;
                }

                scores[typeWinner[0]] += 1;
            }

            GameObject winner = null;
            var highScore = 0;

            foreach (var (player, score) in scores.Select(x => (x.Key, x.Value)))
            {
                if (score > highScore)
                {
                    winner = player;
                    highScore = score;
                }
                else if (score == highScore) // Resolve when more than one player have the same number of biomes controlled
                {
                    winner = null;
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

            // Clear the remaining interface
            // TODO Isolate clear functionality
            DiceRoller.Instance.Clear();
            GameInterfaceManager.Instance.ClearCurrentPlayer();
            GameInterfaceManager.Instance.UpdateTurnCounter(playerTurnsCount / playerCount - 1);
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

    private void InitializePlayers(int playerCount)
    {
        PlayerListManager.Instance.Initialize(playerCount, MapManager.START_POSITION);
        PlayerListManager.Instance.CurrentPlayerIndex = 0;

        GameInterfaceManager.Instance.Initialize();
    }
}
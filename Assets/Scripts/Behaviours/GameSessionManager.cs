using System.Threading;
using UnityEngine;

public class GameSessionManager : MonoBehaviour
{
    private const int PLAYER_COUNT = 2;
   
    private int turnNumber = 0;
    private int movementsLeft = 0;

    public State state { get; private set; }
    public enum State
    {
        Rolling,
        Moving,
        DirectionSelect,
        Waiting
    }

    void Start()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);

        InitializePlayers();
        InitializeGameInterface();

        DiceRoller.Instance.StartRoll();
        MainCameraManager.Instance.ZoomToTarget(PlayerListManager.Instance.GetCurrentPlayer().transform.position);
        state = State.Rolling;
    }

    void Update()
    {
        if (state == State.DirectionSelect)
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

                // Zoom out to overview
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

        if (Input.GetKey(KeyCode.O))
        {
            MainCameraManager.Instance.ForceOverview();
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
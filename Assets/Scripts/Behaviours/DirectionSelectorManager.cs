using UnityEngine;
using UnityEngine.Tilemaps;

public class DirectionSelectorManager : MonoBehaviour
{
    private LineRenderer lineRenderer;
    Tilemap directionMap;
    HexDirectionalTile directionTile;
    private int? directionSelected = null; // Try state, non-null means it's actively being used to select a direction
    private int directionCount = 0;

    private static DirectionSelectorManager instance;

    public static DirectionSelectorManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DirectionSelectorManager>();
            }
            return instance;
        }
    }

    void Start()
    {
        // Create line
        lineRenderer = new GameObject("Line").AddComponent<LineRenderer>();
        lineRenderer.startColor = Color.black;
        lineRenderer.endColor = Color.black;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.positionCount = 2;
        lineRenderer.useWorldSpace = true;
    }

    public bool Active()
    {
        return directionSelected.HasValue;
    }

    public void StartSelection(Tilemap directionMap, GameObject currentPlayer)
    {
        directionSelected = 0;
        UpdateSelector(directionMap, currentPlayer);
    }

    public void UpdateSelector(Tilemap directionMap, GameObject currentPlayer)
    {
        var gridPosition = directionMap.WorldToCell(currentPlayer.transform.position);
        directionTile = (HexDirectionalTile)directionMap.GetTile(gridPosition);

        this.directionCount = directionTile.directions.Count;

        var selectedDirection = directionTile.directions[directionSelected.Value];

        var newPos = CubeCoordUtils.UnityCellToCube(gridPosition) + 2 * GameSessionManager.DIRECTIONS[selectedDirection];

        var directionTarget = directionMap.CellToWorld(CubeCoordUtils.CubeToUnityCell(newPos));

        // Display directional line
        // TODO: Select direction with arrows instead of line
        lineRenderer.enabled = true;

        var translation = new Vector3(0, 0, -2);
        lineRenderer.SetPosition(0, currentPlayer.transform.position + translation);
        lineRenderer.SetPosition(1, directionTarget + translation);
    }

    public int CompleteSelection()
    {
        lineRenderer.enabled = false;

        var dir = directionTile.directions[directionSelected.Value];

        directionTile = null;
        directionSelected = null;
        directionCount = 0;

        return dir;
    }

    public void IncrementSelection(int increment)
    {
        directionSelected = ((directionSelected + increment) + this.directionCount) % this.directionCount;
    }
}

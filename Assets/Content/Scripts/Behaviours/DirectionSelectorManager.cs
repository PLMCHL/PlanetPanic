using UnityEngine;
using UnityEngine.Tilemaps;

public class DirectionSelectorManager : MonoBehaviour
{
    private float LINE_SPACING = 0.225f;
    private float LINE_LENGTH = 0.3f;
    private Vector3 ORIGIN_RELATIVE_POSITION = new Vector3(0, 0.125f, 0);

    private LineRenderer lineRenderer;

    HexDirectionalTile currentPlayerTile;
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

    void Awake()
    {
        lineRenderer = this.gameObject.GetComponent<LineRenderer>();
    }

    public bool Active()
    {
        return directionSelected.HasValue;
    }

    public void StartSelection(GameObject player)
    {
        directionSelected = 0;
        UpdateSelector(player);
    }

    public void UpdateSelector(GameObject player)
    {
        var directionMap = MapManager.Instance.DirectionMap;

        // Find player origin tile
        var playerUnityCellPosition = directionMap.WorldToCell(player.transform.position);
        currentPlayerTile = (HexDirectionalTile)directionMap.GetTile(playerUnityCellPosition);

        // Get the directions
        this.directionCount = currentPlayerTile.directions.Count;
        var selectedDirection = currentPlayerTile.directions[directionSelected.Value];

        // Get target direction world position
        var targetTileCubePosition = CubeCoordUtils.UnityCellToCube(playerUnityCellPosition) + 2 * MapManager.DIRECTIONS[selectedDirection];
        var targetTileWorldPosition = directionMap.CellToWorld(CubeCoordUtils.CubeToUnityCell(targetTileCubePosition));

        // Get selected target direction's orientation vector
        var worldDirectionVector = targetTileWorldPosition - player.transform.position;
        worldDirectionVector.Normalize();

        // Get selector end positions
        var relativeOrigin = player.transform.position + ORIGIN_RELATIVE_POSITION;
        var selectorStartPoint = relativeOrigin + LINE_SPACING * worldDirectionVector;
        var selectorEndPoint = relativeOrigin + (LINE_SPACING + LINE_LENGTH) * worldDirectionVector;

        // Display directional arrow
        lineRenderer.enabled = true;
        lineRenderer.SetPosition(0, selectorStartPoint);
        lineRenderer.SetPosition(1, selectorEndPoint);
    }

    public int CompleteSelection()
    {
        lineRenderer.enabled = false;

        var dir = currentPlayerTile.directions[directionSelected.Value];

        currentPlayerTile = null;
        directionSelected = null;
        directionCount = 0;

        return dir;
    }

    public void IncrementSelection(int increment)
    {
        directionSelected = ((directionSelected + increment) + this.directionCount) % this.directionCount;
    }
}

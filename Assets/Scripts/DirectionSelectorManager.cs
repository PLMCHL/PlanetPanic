using UnityEngine;

public class DirectionSelectorManager : MonoBehaviour
{
    private LineRenderer lineRenderer;

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

    // Start is called before the first frame update
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

    internal void ShowSelector(Vector3 start, Vector3 finish)
    {
        // Display directional line
        lineRenderer.enabled = true;

        // 
        var translation = new Vector3(0, 0, -2);
        lineRenderer.SetPosition(0, start + translation);
        lineRenderer.SetPosition(1, finish + translation);
    }

    internal void HideSelector()
    {
        lineRenderer.enabled = false;
    }
}

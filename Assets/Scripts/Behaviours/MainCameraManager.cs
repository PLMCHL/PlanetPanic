using UnityEngine;

public class MainCameraManager : MonoBehaviour
{
    private Vector3 ZOOM_IN_DISTANCE = new Vector3(0, 0, -1);
    private float ZOOM_IN_ORTHOGRAPHIC_SIZE = 2;
    private float SPEED = 15;

    private static MainCameraManager instance;
    public static MainCameraManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<MainCameraManager>();
            }
            return instance;
        }
    }

    private Vector3 overviewPosition;
    private float overviewOrthographicSize;

    private Vector3 targetPosition;
    private float targetOrthographicSize;

    void Start()
    {
        overviewPosition = this.transform.position;
        overviewOrthographicSize = this.GetComponent<Camera>().orthographicSize;
    }

    void Update()
    {
        var newPosition = Vector3Utils.MoveTowards(this.transform.position, targetPosition, SPEED);
        this.transform.position = newPosition;

        var newOrthographicSize = Mathf.MoveTowards(this.GetComponent<Camera>().orthographicSize, targetOrthographicSize, SPEED);
        this.GetComponent<Camera>().orthographicSize = newOrthographicSize;
    }

    public void ForceOverview()
    {
        this.transform.position = overviewPosition;
        this.GetComponent<Camera>().orthographicSize = overviewOrthographicSize;
    }

    public void ZoomToOverview()
    {
        this.targetPosition = overviewPosition;
        this.targetOrthographicSize = overviewOrthographicSize;
    }

    public void ZoomToTarget(Vector3 position)
    {
        this.targetPosition = position + ZOOM_IN_DISTANCE;
        this.targetOrthographicSize = ZOOM_IN_ORTHOGRAPHIC_SIZE;
    }

    public void ForceZoomToTarget(Vector3 position)
    {
        this.targetPosition = position + ZOOM_IN_DISTANCE;
        this.targetOrthographicSize = ZOOM_IN_ORTHOGRAPHIC_SIZE;

        this.GetComponent<Camera>().orthographicSize = ZOOM_IN_ORTHOGRAPHIC_SIZE;
        this.transform.position = targetPosition;
    }
}

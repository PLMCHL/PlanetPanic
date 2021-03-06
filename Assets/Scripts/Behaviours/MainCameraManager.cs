using UnityEngine;

public class MainCameraManager : MonoBehaviour
{
    private Vector3 ZOOM_IN_DISTANCE = new Vector3(0, 0, -1);
    private float ZOOM_IN_ORTHOGRAPHIC_SIZE = 3;
    private float POSITION_SPEED = 0.5f;
    private float ORTHO_SPEED = 0.1f;

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
        var newPosition = Vector3.MoveTowards(this.transform.position, targetPosition, POSITION_SPEED);
        this.transform.position = newPosition;

        var newOrthographicSize = Mathf.MoveTowards(this.GetComponent<Camera>().orthographicSize, targetOrthographicSize, ORTHO_SPEED);
        this.GetComponent<Camera>().orthographicSize = newOrthographicSize;
    }

    public void ForceOverview()
    {
        var newPosition = Vector3.MoveTowards(this.transform.position, overviewPosition, 2 * POSITION_SPEED);
        this.transform.position = newPosition;

        var newOrthographicSize = Mathf.MoveTowards(this.GetComponent<Camera>().orthographicSize, overviewOrthographicSize, 2 * ORTHO_SPEED);
        this.GetComponent<Camera>().orthographicSize = newOrthographicSize;
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

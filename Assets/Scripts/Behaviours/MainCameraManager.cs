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
        var newPosition = MoveTowards(this.transform.position, targetPosition, SPEED * Time.deltaTime);
        this.transform.position = newPosition;

        var newOrthographicSize = Mathf.MoveTowards(this.GetComponent<Camera>().orthographicSize, targetOrthographicSize, SPEED * Time.deltaTime);
        this.GetComponent<Camera>().orthographicSize = newOrthographicSize;
    }

    public void ZoomOut()
    {
        this.targetPosition = overviewPosition;
        this.targetOrthographicSize = overviewOrthographicSize;
    }

    public void ZoomTo(Vector3 position)
    {
        this.targetPosition = position + ZOOM_IN_DISTANCE;
        this.targetOrthographicSize = ZOOM_IN_ORTHOGRAPHIC_SIZE;
    }

    public void ForceTo(Vector3 position)
    {
        this.targetPosition = position + ZOOM_IN_DISTANCE;
        this.targetOrthographicSize = ZOOM_IN_ORTHOGRAPHIC_SIZE;

        this.GetComponent<Camera>().orthographicSize = ZOOM_IN_ORTHOGRAPHIC_SIZE;
        this.transform.position = targetPosition;
    }

    private Vector3 MoveTowards(Vector3 current, Vector3 target, float speed)
    {
        var newX = Mathf.MoveTowards(current.x, target.x, SPEED * Time.deltaTime);
        var newY = Mathf.MoveTowards(current.y, target.y, SPEED * Time.deltaTime);
        var newZ = Mathf.MoveTowards(current.z, target.z, SPEED * Time.deltaTime);
        return new Vector3(newX, newY, newZ);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraManager : MonoBehaviour
{
    private Vector3 ZOOM_IN_DISTANCE = new Vector3(0, 0, -1);

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
    
    void Start()
    {
        overviewPosition = this.transform.position;
    }

    public void ZoomOut()
    {
        this.transform.position = overviewPosition;
        this.GetComponent<Camera>().orthographicSize = 5;
    }

    public void ZoomTo(Vector3 position)
    {
        this.transform.position = position + ZOOM_IN_DISTANCE;
        this.GetComponent<Camera>().orthographicSize = 2;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationSystem : MonoBehaviour
{
    List<WayPoints> wayPoints = new List<WayPoints>();
    [SerializeField] GameObject electron;
    [SerializeField] float movementSpeed;

    int wayPointIndex;
    bool isReversed;
    bool transitioning;
    private void Awake()
    {
        FillList();
    }

    void FillList()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            wayPoints.Add(gameObject.transform.GetChild(i).GetComponent<WayPoints>());
        }
    }

    void Start()
    {
        isReversed = false;
        transitioning = false;
    }

    void Update()
    {
        CreatePath();
        MoveToNextShell();
    }

    private void CreatePath()
    {
        if (wayPoints[wayPointIndex].EnterCount == 2 && !isReversed)
        {
            PathIncrement();
        }
        else if (wayPoints[wayPointIndex].EnterCount == 2 && isReversed)
        {
            PathDecrement();
        }
    }
    private void PathIncrement()
    {
        wayPoints[wayPointIndex].EnterCount = 0;
        wayPointIndex++;
        electron.GetComponent<Electron>().isRotating = false;
        transitioning = true;
        if (wayPointIndex == wayPoints.Count - 1)
        {
            isReversed = true;
        }
    }

    private void PathDecrement()
    {
        wayPoints[wayPointIndex].EnterCount = 0;
        wayPointIndex--;
        electron.GetComponent<Electron>().isRotating = false;
        transitioning = true;
        if (wayPointIndex == 0)
        {
            isReversed = false;
        }
    }

    private void MoveToNextShell()
    {
        if (transitioning == true && electron.transform.position.y < wayPoints[wayPointIndex].gameObject.transform.position.y)
        {
            float newPos = electron.transform.position.y + Time.deltaTime;
            electron.transform.position = new Vector3(electron.transform.position.x, newPos * movementSpeed, electron.transform.position.z);
        }
        else if (transitioning == true && electron.transform.position.y >= wayPoints[wayPointIndex].gameObject.transform.position.y)
        {
            transitioning = false;
            electron.GetComponent<Electron>().isRotating = true;
            SetRadius();
        }
    }

    private void SetRadius()
    {
        switch (wayPointIndex)
        {
            case 0:
                electron.GetComponent<Electron>().radius = 30;
                break;
            case 1:
                electron.GetComponent<Electron>().radius = 43;
                break;
            case 2:
                electron.GetComponent<Electron>().radius = 54;
                break;
            case 3:
                electron.GetComponent<Electron>().radius = 82;
                break;
            case 4:
                electron.GetComponent<Electron>().radius = 97;
                break;
            case 5:
                electron.GetComponent<Electron>().radius = 127;
                break;
            case 6:
                electron.GetComponent<Electron>().radius = 148;
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    public float speed;
    Vector3 targetPos;

    public GameObject pathways;
    public Transform[] wayPoints;
    int pointIndex;
    int pointCount;
    int direction = 1;

    private void Awake()
    {
        wayPoints = new Transform[pathways.transform.childCount];
        for (int i = 0; i < pathways.gameObject.transform.childCount; i++)
        {
            wayPoints[i] = pathways.transform.GetChild(i).gameObject.transform;
        }
    }

    private void Start()
    {
        pointCount = wayPoints.Length;
        pointIndex = 1;
        targetPos = wayPoints[pointIndex].transform.position;
    }

    private void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, step);

        if (transform.position == targetPos)
        {
            NextPoint();
        }

    }

    void NextPoint()
    {
        if (pointIndex == pointCount - 1) // arrived at last point
        {
            direction = -1;
        }

        if (pointIndex == 0) // arrived at first point
        {
            direction = 1;
        }

        pointIndex += direction;
        targetPos = wayPoints[pointIndex].transform.position;

    }

}

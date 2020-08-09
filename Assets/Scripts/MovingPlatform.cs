using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public Vector3[] currentPoint = new Vector3[3];
    int targetIndex;

    void Start()
    {
        targetIndex = 0;
    }

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, currentPoint[targetIndex], Time.deltaTime * speed);
        
        if (transform.position == currentPoint[targetIndex])
        {
            targetIndex = (targetIndex + 1) % currentPoint.Length;
        }
    }
}

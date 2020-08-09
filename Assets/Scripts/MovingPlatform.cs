using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public float speed;

    private float current; // от 0 до 1
    private float dir;

    // Start is called before the first frame update
    void Start()
    {
        current = 0.0f;
        dir = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        current += dir * speed * Time.deltaTime;
        if (current > 1.0f) {
            current = 1.0f;
            dir = -1.0f;
        } else if (current < 0.0f) {
            current = 0.0f;
            dir = 1.0f;
        }

        transform.position = Vector3.Lerp(top.position, bottom.position, current);
    }
}

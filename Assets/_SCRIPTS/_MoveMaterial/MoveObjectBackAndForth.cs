using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectBackAndForth : MonoBehaviour
{
    [SerializeField] protected Transform pointA;
    [SerializeField] protected Transform pointB;

    [SerializeField] protected float speed = 3.0f;

    protected Vector3 target;

    void Start()
    {
        target = pointB.position;
    }

    void Update()
    {
        this.MoveToDestination();
    }

    protected void MoveToDestination()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            if (target == pointB.position)
            {
                target = pointA.position;
            }
            else
            {
                target = pointB.position;
            }
        }
    }
}

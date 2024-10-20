using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowToCar : MonoBehaviour
{
    [SerializeField] protected Transform targetCar;
    [SerializeField] protected float speed;
    [SerializeField] protected float acceleration;
    protected float InitalSpeedCar;
    private void Start()
    {
        InitalSpeedCar = speed;
    }
    private void Update()
    {
        InitalSpeedCar += acceleration * Time.deltaTime;
        Vector3 targetPos = targetCar.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, InitalSpeedCar * Time.deltaTime);
    }
}

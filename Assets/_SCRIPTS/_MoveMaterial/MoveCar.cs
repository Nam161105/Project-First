using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    [SerializeField] protected float addSpeed;
    [SerializeField] protected float timeSpeed;
    [SerializeField] protected float slowSpeed; 
    [SerializeField] protected float timeSlow; 

    protected float initialMoveSpeed;
    [SerializeField] protected bool isBoosted = false;
    [SerializeField] protected bool isSlowed = false;

    void Start()
    {
        initialMoveSpeed = ControllerCar.Instance.speedMove;
    }

    void Update()
    {
        this.ProcessingMove();
    }

    protected virtual void ProcessingMove()
    {
        float SpeedMove = Input.GetAxis("Vertical") * ControllerCar.Instance.speedMove * Time.deltaTime;
        float SpeedSteer = Input.GetAxis("Horizontal") * ControllerCar.Instance.speedSteer * Time.deltaTime;

        transform.Translate(0, SpeedMove, 0);
        transform.Rotate(0, 0, -SpeedSteer);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Flash")) this.BoostSpeed();
        if (collision.CompareTag("Spike") || collision.CompareTag("Tree")) this.SlowSpeed();  
    }

    protected virtual void BoostSpeed()
    {
        if (!isBoosted)
        {
            isBoosted = true;
            ControllerCar.Instance.speedMove += addSpeed;
            Invoke("ResetSpeed", timeSpeed);
        }
    }

    protected virtual void SlowSpeed()
    {
        if (!isSlowed)
        {
            isSlowed = true;
            ControllerCar.Instance.speedMove += slowSpeed;
            Invoke("ResetSpeed", timeSlow);
        }
    }
    protected virtual void ResetSpeed()
    {
        ControllerCar.Instance.speedMove = initialMoveSpeed;
        isBoosted = false;
        isSlowed = false;
    }

}

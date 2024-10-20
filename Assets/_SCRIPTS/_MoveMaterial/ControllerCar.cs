using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCar : MonoBehaviour
{
    protected static ControllerCar instance;
    public static ControllerCar Instance { get { return instance; } }
    [SerializeField] protected float MoveSpeed;
    public float speedMove { get; set; }
    [SerializeField] protected float SteerSpeed;
    public float speedSteer { get { return SteerSpeed; } }

    private void Awake()
    {
        if (ControllerCar.instance != null) Debug.LogError("Has 1 ControlerCar duplicated");
        ControllerCar.instance = this;
    }
    private void Update()
    {
        this.GetKeyPos();
    }


    protected virtual void GetKeyPos()
    {
        if (TextGame.isGameOver)
        {
            return;
        }

        float SpeedMove = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        float SpeedSteer = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime;

        transform.Translate(0, SpeedMove, 0);
        transform.Rotate(0, 0, -SpeedSteer);

    }
}

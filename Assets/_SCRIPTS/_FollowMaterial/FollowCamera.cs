using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]  protected GameObject followThing;
    
    void LateUpdate()
    {
        this.MoveToCamera();
    }

    protected virtual void MoveToCamera()
    {
        this.transform.position = followThing.transform.position + new Vector3(0, 0, -10);
    }
}

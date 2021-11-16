using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    public float speed;

    private WheelJoint2D wheel;
    private JointMotor2D motor; 

    void Start()
    {
        wheel = this.gameObject.GetComponent<WheelJoint2D>();
        motor = wheel.motor;
    }


    void Update()
    {
        float xForce = Input.GetAxis("Horizontal");
        motor.motorSpeed = speed * xForce;
        wheel.motor = motor;
    }
}

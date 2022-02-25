using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Transform centerOfMass;
    public float motorTorque;
    public float steerAngle;
    public float brakeTorque;

    public float Steer { get; set; }
    public float Accelerator { get; set; }
    public float Brake { get; set; }

    private Rigidbody rgdbody;
    private Wheel[] wheels;

    //wheels � um array e armazena as n rodas que o ve�culo possui.
    void Start()
    {
        rgdbody = GetComponent<Rigidbody>();
        rgdbody.centerOfMass = centerOfMass.localPosition;
        wheels = GetComponentsInChildren<Wheel>();
    }

    //Steer = SteerInput, Accelerator = AcceleratorInput, etc. S� passando os dados do InputManager pra essas vari�veis.
    private void Update()
    {
        foreach (var wheel in wheels)
        {
            wheel.SteerAngle = Steer * steerAngle;
            wheel.MotorTorque = Accelerator * motorTorque;
            wheel.BrakeTorque = Brake * brakeTorque;
        }
    }
}


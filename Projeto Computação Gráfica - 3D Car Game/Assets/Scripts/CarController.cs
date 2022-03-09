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

    //Ajusta o centro de massa do veículo
    //wheels é um array que armazena as n rodas que o veículo possui
    void Start()
    {
        rgdbody = GetComponent<Rigidbody>();
        rgdbody.centerOfMass = centerOfMass.localPosition;
        wheels = GetComponentsInChildren<Wheel>();
    }

    //Passa os dados de controle do player para as variáveis abaixo
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public bool steer;
    public bool invertSteer;
    public bool power;

    public float SteerAngle { get; set; }
    
    public float MotorTorque { get; set; }

    public float BrakeTorque { get; set; }

    private WheelCollider wheelCollider;
    private Transform wheelTransform;

    void Start()
    {
        wheelCollider = GetComponentInChildren<WheelCollider>();
        wheelTransform = GetComponentInChildren<MeshRenderer>().GetComponent<Transform>();
    }

    //Atualiza a posição e rotação visual das rodas de acordo com a posição e rotação dos Wheel Colliders.
    void Update()
    {
        wheelCollider.GetWorldPose(out Vector3 pos, out Quaternion rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
    }

    private void FixedUpdate()
    {
        if(steer)
        {
            wheelCollider.steerAngle = SteerAngle * (invertSteer ? -1 : 1);
        }

        if(power)
        {
            wheelCollider.motorTorque = MotorTorque;
        }

        wheelCollider.brakeTorque = BrakeTorque;
    }
}
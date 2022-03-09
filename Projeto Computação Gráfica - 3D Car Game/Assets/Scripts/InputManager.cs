using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public string inputAcceleratorAxis = "Vertical";
    public string inputSteerAxis = "Horizontal";
    public string inputBrakeAxis = "Jump";

    public float AcceleratorInput { get; private set; }
    public float SteerInput { get; private set; }
    public float BrakeInput { get; private set; }

    void Update()
    {
        AcceleratorInput = Input.GetAxis(inputAcceleratorAxis);
        SteerInput = Input.GetAxis(inputSteerAxis);
        BrakeInput = Input.GetAxis(inputBrakeAxis);
    }
}
//SteerInput verifica e armazena se as teclas horizontais estão sendo pressionadas, AcceleratorleInput faz o mesmo mas com as verticais. BrakeInput pega a tecla Espaço. Esse código só faz isso.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum ControlType { HumanInput, AI }
    public ControlType controlType = ControlType.HumanInput;

    public float BestLapTime { get; private set; } = Mathf.Infinity;
    public float LastLapTime { get; private set; } = 0;
    public float CurrentLapTime { get; private set; } = 0;
    public int CurrentLap { get; private set; } = 0;

    private float lapTimer;
    private int lastCheckpoint;
    private Transform checkpointsParent;
    private int checkpointsCount;
    private int checkpointsLayer;
    private CarController carController;



    void Awake()
    {
        checkpointsParent = GameObject.Find("Checkpoints").transform;
        checkpointsCount = checkpointsParent.childCount - 1;
        checkpointsLayer = LayerMask.NameToLayer("Checkpoints");
        carController = GetComponent<CarController>();
    }

    void StartLap()
    {
        CurrentLap++;
        lastCheckpoint = 0;
        lapTimer = Time.time;
    }

    void EndLap()
    {
        LastLapTime = Time.time - lapTimer;
        BestLapTime = Mathf.Min(LastLapTime, BestLapTime);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.layer != checkpointsLayer)
        {
            return;
        }

        if(collider.gameObject.name == "0")
        {

            if(lastCheckpoint == checkpointsCount)
            {
                EndLap();
            }

            if (CurrentLap == 0 || lastCheckpoint == checkpointsCount)
            {
                StartLap();
            }
        }

        if(collider.gameObject.name == (lastCheckpoint + 1).ToString())
        {
            lastCheckpoint++;
        }
    }

    void Update()
    {
        CurrentLapTime = lapTimer > 0 ? Time.time - lapTimer : 0;

        if(controlType == ControlType.HumanInput)
        {
            carController.Steer = GameManager.Instance.InputManager.SteerInput;
            carController.Accelerator = GameManager.Instance.InputManager.AcceleratorInput;
            carController.Brake = GameManager.Instance.InputManager.BrakeInput;
        }
    }
}

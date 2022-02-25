using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public Renderer brakeLights;
    public Material brakeLightsOn;
    public Material brakeLightsOff;
    public Renderer headLights;
    public Material headLightsOn;
    public Material headLightsOff;
    private int headLightsSwitch = -1;
    public Light LFLight;
    public Light RFLight;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.S))
        {
            brakeLights.material = brakeLightsOn;
        }

        else
        {
            brakeLights.material = brakeLightsOff;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            headLightsSwitch *= -1;
        }

        if (headLightsSwitch == 1)
        {
            headLights.material = headLightsOn;
            LFLight.intensity = 100f;
            RFLight.intensity = 100f;
        }

        else
        {
            headLights.material = headLightsOff;
            LFLight.intensity = 0;
            RFLight.intensity = 0;
        }
    }
}

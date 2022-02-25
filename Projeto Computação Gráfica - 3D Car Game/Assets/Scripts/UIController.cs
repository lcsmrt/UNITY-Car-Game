using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject UIInGamePanel;

    public Text UITextCurrentLap;
    public Text UITextTimer;
    public Text UITextLastLap;
    public Text UITextBestLap;

    public Player UpdateUIForPlayer;

    private int currentLap = 0;
    private float currentLapTime;
    private float lastLapTime;
    private float bestLapTime;

    void Update()
    {
        if(UpdateUIForPlayer == null)
        {
            return;
        }

        if(UpdateUIForPlayer.CurrentLap != currentLap)
        {
            currentLap = UpdateUIForPlayer.CurrentLap;
            UITextCurrentLap.text = $"VOLTA: {currentLap}";
        }

        if (UpdateUIForPlayer.CurrentLapTime != currentLapTime)
        {
            currentLapTime = UpdateUIForPlayer.CurrentLapTime;
            UITextTimer.text = $"TEMPO: {(int)currentLapTime / 60}:{(currentLapTime) % 60:00.000}";
        }

        if (UpdateUIForPlayer.LastLapTime != lastLapTime)
        {
            lastLapTime = UpdateUIForPlayer.LastLapTime;
            UITextLastLap.text = $"ÚLTIMA VOLTA: {(int)lastLapTime / 60}:{(lastLapTime) % 60:00.000}";
        }

        if (UpdateUIForPlayer.BestLapTime != bestLapTime)
        {
            bestLapTime = UpdateUIForPlayer.BestLapTime;
            UITextBestLap.text = bestLapTime < 1000000 ? $"MELHOR TEMPO: {(int)bestLapTime / 60}:{(bestLapTime) % 60:00.000}" : "MELHOR TEMPO: 00:00:00";
        }
    }
}

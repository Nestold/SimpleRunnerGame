using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    public UIGameOverPanel GameOverPanel = null;

    [SerializeField] private TextMeshProUGUI timer = null;

    public void SetTimer(float seconds)
    {
        TimeSpan time = TimeSpan.FromSeconds(seconds);
        timer.text = $"{time.Minutes.ToString("00")}:{time.Seconds.ToString("00")}:{time.Milliseconds.ToString("000")}";
    }
}

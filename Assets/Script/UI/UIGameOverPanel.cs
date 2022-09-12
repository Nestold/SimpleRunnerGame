using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOverPanel : UIPanel
{
    [SerializeField] private Button backButton = null;
    [SerializeField] private Button replayButton = null;

    private void Start()
    {
        backButton.onClick.AddListener(OnBackClick);
        replayButton.onClick.AddListener(OnReplayClick);
    }

    private void OnReplayClick()
    {
        FindObjectOfType<GameManager>().NewGame(false);
    }
    private void OnBackClick()
    {
        Debug.Log("BackButton");
    }
}
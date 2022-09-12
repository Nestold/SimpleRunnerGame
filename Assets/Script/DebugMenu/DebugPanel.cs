using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugPanel : MonoBehaviour
{
    [SerializeField] private GameObject panel = null;

    [Header("Buttons")]
    [SerializeField] private Button addLife = null;
    [SerializeField] private Button removeLife = null;

    private void Start()
    {
        panel.SetActive(false);

        addLife.onClick.AddListener(OnAddLife);
        removeLife.onClick.AddListener(OnRemoveLife);
    }

    private void OnRemoveLife()
    {
        var player = FindObjectOfType<Player>();
        player.GetComponent<LifeController>().RemoveLife(10);
    }

    private void OnAddLife()
    {
        var player = FindObjectOfType<Player>();
        player.GetComponent<LifeController>().AddLife(10);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            panel.SetActive(!panel.activeSelf);
        }
    }
}
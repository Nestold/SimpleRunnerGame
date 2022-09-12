using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool Pause { get; set; } = false;

    [Header("UI Settings")]
    public UIManager UIManager = null;

    [Header("Player settings")]
    [SerializeField] private Player player;
    [SerializeField] private CharacterConfig defaultCharacterSettings;

    [Header("Map")]
    [SerializeField] private MapGenerator mapGenerator = null;

    private List<EnemySpawner> enemySpawners;
    private float gameTimer = 0f;

    private void Start()
    {
        NewGame(true);
    }
    private void Update()
    {
        if(!Pause)
        {
            gameTimer += Time.deltaTime;
            UIManager.SetTimer(gameTimer);
        }
    }

    public void NextLevel()
    {
        mapGenerator.MaxSegments += 5;
        NewGame(true);
    }
    public void GameOver()
    {
        UIManager.GameOverPanel.Show();
        Pause = true;
    }
    public void NewGame(bool newMap)
    {
        gameTimer = 0f;
        UIManager.SetTimer(gameTimer);

        if (enemySpawners == null)
        {
            enemySpawners = FindObjectsOfType<EnemySpawner>().ToList();
        }
        else
        {
            foreach(var enemy in enemySpawners)
            {
                enemy.Clear();
            }
        }

        player.Setup(defaultCharacterSettings);
        if (UIManager.GameOverPanel.IsShow)
            UIManager.GameOverPanel.Hide();

        Pause = false;

        if(newMap)
        {
            mapGenerator.CreateNewMap();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int maxEnemies = 1;
    [SerializeField] private List<Enemy> enemies = null;
    [SerializeField] private float spawnDelay = 5f;

    private float timer = 0;

    private void Start()
    {
        timer = spawnDelay;
    }
    private void Update()
    {
        if(!GameManager.Pause)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                if(transform.childCount < maxEnemies)
                {
                    Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Count)],
                        new Vector3(transform.position.x, .5f, transform.position.z),
                        Quaternion.Euler(Vector3.zero),
                        transform);

                    timer = spawnDelay;
                }
            }
        }
    }

    public void Clear()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }
    }
}
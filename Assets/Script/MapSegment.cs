using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSegment : MonoBehaviour
{
    [Header("Neighbour Settings")]
    [SerializeField] private List<Transform> neighbours = null;

    [Header("Obstacles Settings")]
    [SerializeField] private bool spawnObstacles = false;
    [SerializeField] private int maxObstaclesActive = 1;
    [SerializeField] private Transform obstaclesParent = null;

    private MapGenerator generator;

    public void Setup(MapGenerator generator)
    {
        this.generator = generator;
        CreateNeighbour();
        SpawnObstacles();
    }

    private void CreateNeighbour()
    {
        foreach(Transform t in neighbours)
        {
            var segment = Instantiate(generator.GetRandomSegment(), t);
            segment.Setup(generator);
        }
    }
    private void SpawnObstacles()
    {
        if(obstaclesParent != null)
        {
            foreach (Transform o in obstaclesParent)
            {
                if (o != null)
                    o.gameObject.SetActive(false);
            }

            if (spawnObstacles)
            {
                for (int i = 0; i < maxObstaclesActive; i++)
                {
                    var lucyNumber = UnityEngine.Random.Range(0, obstaclesParent.childCount);
                    if (obstaclesParent.GetChild(lucyNumber) != null)
                        obstaclesParent.GetChild(lucyNumber).gameObject.SetActive(true);
                }
            }
        }
    }
}
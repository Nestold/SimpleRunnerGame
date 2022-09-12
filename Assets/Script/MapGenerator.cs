using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private MapSegment startSegment = null;
    [SerializeField] private List<MapSegment> segments = null;
    [SerializeField] private MapSegment endSegment = null;

    [Header("Settings")]
    public int MaxSegments = 5;

    private int spawnedSegments = 0;
  
    public void CreateNewMap()
    {
        if(transform.childCount > 0)
        {
            Destroy(transform.GetChild(0).gameObject);
            spawnedSegments = 0;
        }
        var startSeg = Instantiate(startSegment, transform);
        startSeg.transform.localPosition = Vector3.zero;
        startSeg.Setup(this);
    }

    public MapSegment GetRandomSegment()
    {
        spawnedSegments++;
        if (spawnedSegments < MaxSegments)
        {
            var lNumber = UnityEngine.Random.Range(0, segments.Count);
            return segments[lNumber];
        }
        else
        {
            return endSegment;
        }
    }
}
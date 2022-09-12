using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMapSegment : MapSegment
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            FindObjectOfType<GameManager>().NextLevel();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset = Vector3.zero;
    [SerializeField] private Transform follow = null;

    private void Update()
    {
        transform.position = follow.position + offset;
    }
}

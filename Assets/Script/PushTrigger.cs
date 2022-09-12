using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushTrigger : MonoBehaviour
{
    [SerializeField] private Animator animator = null;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            animator.SetTrigger("Push");
        }
    }
}
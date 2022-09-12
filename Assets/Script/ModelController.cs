using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    public Animator Animator { get; private set; } = null;

    public void Setup(GameObject prefab)
    {
        if (transform.childCount > 0)
            Destroy(transform.GetChild(0).gameObject);

        Animator = Instantiate(prefab, transform).GetComponent<Animator>();
        Animator.transform.localPosition = Vector3.zero;
        Animator.transform.localRotation = Quaternion.Euler(Vector3.zero);
    }
}
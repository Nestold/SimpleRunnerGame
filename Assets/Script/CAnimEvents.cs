using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAnimEvents : MonoBehaviour
{
    private PlayerController pController;

    public void SetCCHeight(float height)
    {
        if(pController == null)
        {
            pController = transform.parent.GetComponentInParent<PlayerController>();
        }
        pController.SetHeight(height);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDamageText : LookAtCamera
{
    [SerializeField] private TextMeshPro text = null;

    protected void Destroy()
    {
        Destroy(gameObject);
    }

    public void SetText(string text)
    {
        this.text.text = text;
    }
}

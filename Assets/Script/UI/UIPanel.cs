using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIPanel : MonoBehaviour
{
    public bool IsShow => gameObject.activeSelf;

    protected virtual void OnShow()
    {

    }
    protected virtual void OnHide()
    {

    }

    public void Show()
    {
        OnShow();
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        OnHide();
        gameObject.SetActive(false);
    }
}

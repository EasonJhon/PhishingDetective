using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingPlane : MonoSingleton<LoadingPlane>
{
    protected override void Awake()
    {
        base.Awake();
        this.gameObject.SetActive(false);
    }

    public void Show(Action action)
    {
        this.gameObject.SetActive(true);
        StartCoroutine(ShowIE(action));
    }

    private IEnumerator ShowIE(Action action)
    {
        yield return new WaitForSeconds(3F);

        action?.Invoke();

        this.gameObject.SetActive(false);
    }
}

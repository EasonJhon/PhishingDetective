using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPlane : MonoSingleton<StartPlane>
{
    public Button LoginBtn;

    protected override void Awake()
    {
        base.Awake();

        LoginBtn.onClick.AddListener(() => 
        {
            ContinuePlane.Self.gameObject.SetActive(true);
          this.gameObject.SetActive(false);
        });
    }
}

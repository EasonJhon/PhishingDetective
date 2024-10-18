using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class ContinuePlane : MonoSingleton<ContinuePlane>
{
    private string userName;

    public InputField inputField;

    public Button loginBtn;

    protected override void Awake()
    {
        base.Awake();

        this.gameObject.SetActive(false);

        loginBtn.onClick.AddListener(() =>
        {
            userName = inputField.text;

            LoadingPlane.Self.Show(() =>
            {
                RulesPlane.Self.gameObject.SetActive(true);
            });

            this.gameObject.SetActive(false);
        });
    }
}

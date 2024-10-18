using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RulesPlane : MonoSingleton<RulesPlane>
{
    public Button login, selected1, selected2, selected3;

    public int typeRules = 0;

    public Transform[] transforms;

    public void Hied()
    {
        foreach (Transform t in transforms)
            t.gameObject.SetActive(false);

        transforms[typeRules].gameObject.SetActive(true);

        this.gameObject.SetActive(false);
    }

    protected override void Awake()
    {
        base.Awake();

        this.gameObject.SetActive(false);

        login.onClick.AddListener(() =>
        {
         //   Hied();
        });
        //login2.onClick.AddListener(() =>
        //{
        //    Hied();
        //});

        selected1.onClick.AddListener(() =>
        {
            typeRules = 0;
            Transform Trans = transform.GetChild(transform.childCount - 1);

            Vector3 pos1= Trans.position;

            Vector3 rotate1 = Trans.eulerAngles;

            Vector3 slcale1 = Trans.localScale;

            Vector3 pos2 = selected1.transform.position;

            Vector3 rotate2 = selected1.transform.eulerAngles;

            Vector3 slcale2 = selected1.transform.localScale;

            selected1.transform.position = pos1;

            selected1.transform.eulerAngles = rotate1;

            selected1.transform.localScale= slcale1;

            Trans.transform.position = pos2;

            Trans.transform.eulerAngles = rotate2;

            Trans.transform.localScale = slcale2;

            Trans.SetSiblingIndex(selected1.transform.GetSiblingIndex());

            selected1.transform.SetSiblingIndex(transform.childCount-1);
        });

        selected2.onClick.AddListener(() =>
        {
            typeRules = 1;
            Transform Trans = transform.GetChild(transform.childCount - 1);

            Vector3 pos1 = Trans.position;

            Vector3 rotate1 = Trans.eulerAngles;

            Vector3 slcale1 = Trans.localScale;

            Vector3 pos2 = selected2.transform.position;

            Vector3 rotate2 = selected2.transform.eulerAngles;

            Vector3 slcale2 = selected2.transform.localScale;

            selected2.transform.position = pos1;

            selected2.transform.eulerAngles = rotate1;

            selected2.transform.localScale = slcale1;

            Trans.transform.position = pos2;

            Trans.transform.eulerAngles = rotate2;

            Trans.transform.localScale = slcale2;

            Trans.SetSiblingIndex(selected2.transform.GetSiblingIndex());

            selected2.transform.SetSiblingIndex(transform.childCount - 1);
        });

        selected3.onClick.AddListener(() =>
        {
            typeRules = 2;
            Transform Trans = transform.GetChild(transform.childCount - 1);

            Vector3 pos1 = Trans.position;

            Vector3 rotate1 = Trans.eulerAngles;

            Vector3 slcale1 = Trans.localScale;

            Vector3 pos2 = selected3.transform.position;

            Vector3 rotate2 = selected3.transform.eulerAngles;

            Vector3 slcale2 = selected3.transform.localScale;

            selected3.transform.position = pos1;

            selected3.transform.eulerAngles = rotate1;

            selected3.transform.localScale = slcale1;

            Trans.transform.position = pos2;

            Trans.transform.eulerAngles = rotate2;

            Trans.transform.localScale = slcale2;

            Trans.SetSiblingIndex(selected3.transform.GetSiblingIndex());

            selected3.transform.SetSiblingIndex(transform.childCount - 1);
        });
    }
}

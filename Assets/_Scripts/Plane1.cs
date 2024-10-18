using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plane1 : MonoSingleton<Plane1>
{
    public Button button1, button2;

    protected override void Awake()
    {
        base.Awake();

        this.gameObject.SetActive(true);

        //button1.onClick.AddListener(() =>
        //{
        //    Transform Trans = transform.GetChild(transform.childCount - 1);

        //    Vector3 pos1 = Trans.position;

        //    Vector3 rotate1 = Trans.eulerAngles;

        //    Vector3 slcale1 = Trans.localScale;

        //    Vector3 pos2 = button1.transform.position;

        //    Vector3 rotate2 = button1.transform.eulerAngles;

        //    Vector3 slcale2 = button1.transform.localScale;

        //    button1.transform.position = pos1;

        //    button1.transform.eulerAngles = rotate1;

        //    button1.transform.localScale = slcale1;

        //    Trans.transform.position = pos2;

        //    Trans.transform.eulerAngles = rotate2;

        //    Trans.transform.localScale = slcale2;

        //    Trans.SetSiblingIndex(button1.transform.GetSiblingIndex());

        //    button1.transform.SetSiblingIndex(transform.childCount - 1);
        //});

        //button2.onClick.AddListener(() =>
        //{
        //    Transform Trans = transform.GetChild(transform.childCount - 1);

        //    Vector3 pos1 = Trans.position;

        //    Vector3 rotate1 = Trans.eulerAngles;

        //    Vector3 slcale1 = Trans.localScale;

        //    Vector3 pos2 = button2.transform.position;

        //    Vector3 rotate2 = button2.transform.eulerAngles;

        //    Vector3 slcale2 = button2.transform.localScale;

        //    button2.transform.position = pos1;

        //    button2.transform.eulerAngles = rotate1;

        //    button2.transform.localScale = slcale1;

        //    Trans.transform.position = pos2;

        //    Trans.transform.eulerAngles = rotate2;

        //    Trans.transform.localScale = slcale2;

        //    Trans.SetSiblingIndex(button2.transform.GetSiblingIndex());

        //    button2 .transform.SetSiblingIndex(transform.childCount - 1);
        //});
    }
}

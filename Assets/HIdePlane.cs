using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIdePlane : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(StartHide());
    }

    // Start is called before the first frame update
    IEnumerator StartHide()
    {
        yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STARTCTR : MonoBehaviour
{
    public Button[] STARTCTRS;

    public Image[] IMAGES;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < STARTCTRS.Length; i++)
        {
            if (STARTCTRS[i] != null)
            {
                int index = i;

                STARTCTRS[i].onClick.AddListener(() =>
                { 
                    int cout = STARTCTRS[index].transform.GetSiblingIndex();

                    Debug.LogError(cout);

                    for (int j = 0; j < IMAGES.Length; j++)
                    {
                        if (j <=cout)
                            IMAGES[j].gameObject.SetActive(true);
                        else
                            IMAGES[j].gameObject.SetActive(false);
                    }
                });
            }
        }
    }
}

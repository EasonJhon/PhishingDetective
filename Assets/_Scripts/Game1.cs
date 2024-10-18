using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Game1 : MonoBehaviour
{
    public Text timerText;

    private float timerTime;

    public Transform clicks;

    public Transform plane;

    public List<Button> gameObjects = new List<Button>();

    public UnityAction c;

    void OnEnable()
    {
        timerTime = 60;
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button button in gameObjects)
        {
            button.onClick.AddListener(() =>
            {
               gameObjects.Remove(button);

                Destroy (button);

                if (gameObjects.Count == 0)
                    c.Invoke();
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        timerTime -= Time.deltaTime;


        if (timerTime < 60)
            timerText.text = Convert.ToInt32(timerTime).ToString("00:00:00");

        if (timerTime > 30 && timerTime < 32)
        {
            clicks.gameObject.SetActive(true);
        }

        if (timerTime <= 0)
        {
            timerText.text = "00:00:00";

            plane.gameObject.SetActive(true);

            this.gameObject.SetActive(false);
        }
    }
}

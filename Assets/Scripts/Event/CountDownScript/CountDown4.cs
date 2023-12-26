using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class CountDown4 : MonoBehaviour
{

    public GameObject _main;
    main mainManager;

    public static float CountDownTime;
    public Text TextCountDown;
    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 40.0F;
        mainManager = _main.GetComponent<main>();
    }

    // Update is called once per frame
    void Update()
    {
        TextCountDown.text = String.Format("Žc‚è:{0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;

        if (CountDownTime <= 0.0F)
        {
            SceneManager.LoadScene("To5ST");
            mainManager.Stop();
        }
    }
}

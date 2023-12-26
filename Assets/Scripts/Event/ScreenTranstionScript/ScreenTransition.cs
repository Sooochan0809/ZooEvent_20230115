using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
    public GameObject _main;
    main mainManager;

    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("Start");
        mainManager = _main.GetComponent<main>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        SceneManager.LoadScene("Explain");
        mainManager.Stop();
    }
}

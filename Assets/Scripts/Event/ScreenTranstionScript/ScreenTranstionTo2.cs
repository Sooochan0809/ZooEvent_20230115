using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTranstionTo2 : MonoBehaviour
{

    public GameObject _main;
    main mainManager;

    // Start is called before the first frame update
    void Start()
    {
        mainManager = _main.GetComponent<main>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Zebra_02");
    }

}//‚±‚ê‚ªA‚µ‚Ü‚¤‚Ü‚ÌWatar‚ğn‚ß‚é‚½‚ß‚ÌScript


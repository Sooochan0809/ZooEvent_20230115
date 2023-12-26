using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
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
    public void NextButton()
    {
        SceneManager.LoadScene("To2ST");
        mainManager.Stop();
    }
    public void FinishButton()
    {
        SceneManager.LoadScene("Finish");
    }
}
//ÇµÇ‹Ç§Ç‹ÇÃWalkÇ∆WatarÇèIÇ¶ÇÈÇΩÇﬂÇÃScript
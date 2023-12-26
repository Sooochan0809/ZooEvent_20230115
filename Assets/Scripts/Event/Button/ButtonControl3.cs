using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl3 : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;


    public void OnPushwalk()
    {
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(true);

    }
    public void OnPushdrink()
    {
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(true);
        E.SetActive(false);
    }
    
    // Start is called before the first frame update
    private void Start()
    {
        D.SetActive(false);
        E.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviewControl : MonoBehaviour
{
    public GameObject A;
    public GameObject B;

    public void OnPushButtonNext()
    {
        A.SetActive(true);
        B.SetActive(false);
    }
    public void OnPushButtonBack()
    {
        A.SetActive(false);
        B.SetActive(true);
    }

    // Start is called before the first frame update
    private void Start()
    {
        OnPushButtonBack();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera Camera;
    public Camera ChildCamera;
    // Start is called before the first frame update
    void Start()
    {
        ChildCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCameraButton()
    {
        if (!ChildCamera.enabled)
        {
            ChildCamera.enabled = true;
            Camera.enabled = false;
            //Canvas.GetComponet<Canvas>().worldCamera = ChildCamera;
        }
        else
        {
            ChildCamera.enabled = false;
            Camera.enabled = true;
            //Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
    }
}

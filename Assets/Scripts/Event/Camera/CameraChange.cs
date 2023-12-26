
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera mainCamera = default; //メインカメラ
    public Camera subCamera1 = default; //サブカメラ1
    public Camera subCamera2 = default; //サブカメラ2
    void Start()
    {
        //メインカメラを設定
        mainCamera = Camera.main;
        //メインカメラを有効化する
        ActiveMainCamera();
    }

    void Update() { }

    //関数：メインカメラを有効化
    public void ActiveMainCamera()
    {
        subCamera1.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
    }

    //関数：サブカメラ1を有効化
    public void ActiveSubCamera1()
    {
        mainCamera.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(false);
        subCamera1.gameObject.SetActive(true);
    }

    //関数：サブカメラ2を有効化
    public void ActiveSubCamera2()
    {
        mainCamera.gameObject.SetActive(false);
        subCamera1.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(true);
    }
}

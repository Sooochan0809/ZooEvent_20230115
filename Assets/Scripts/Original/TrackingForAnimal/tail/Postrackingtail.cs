using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postrackingtail : MonoBehaviour
{
    [SerializeField]
    GameObject Hpelvis;

    [SerializeField]
    GameObject tail;

    Vector3 sHuman1Pos, sAnimal1Pos;

    // Start is called before the first frame update
    void Start()
    {

        sAnimal1Pos = tail.transform.position;

    }

    // Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            sHuman1Pos = Hpelvis.transform.position;


        var cHuman1Pos = Hpelvis.transform.position;
        var subHuman1Pos = cHuman1Pos - sHuman1Pos;
        var subanimal1Pos = sAnimal1Pos + subHuman1Pos;
        tail.transform.position = subanimal1Pos;

    }
}

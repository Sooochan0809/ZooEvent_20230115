using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostrackingfootL : MonoBehaviour
{
    [SerializeField]
    GameObject Lhhip;
    [SerializeField]
    GameObject Lhknee;
    [SerializeField]
    GameObject Lhankle;
    [SerializeField]
    GameObject Lhfoot;

    [SerializeField]
    GameObject Lahip;
    [SerializeField]
    GameObject Laknee;
    [SerializeField]
    GameObject Laankle;
    [SerializeField]
    GameObject Lafoot;

    Vector3 sHuman1Pos, sAnimal1Pos, sHuman2Pos, sAnimal2Pos, sHuman3Pos, sAnimal3Pos, sHuman4Pos, sAnimal4Pos;

    // Start is called before the first frame update
    void Start()
    {

        sAnimal1Pos = Lahip.transform.position;
        sAnimal2Pos = Laknee.transform.position;
        sAnimal3Pos = Laankle.transform.position;
        sAnimal4Pos = Lafoot.transform.position;

    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman1Pos = Lhhip.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman2Pos = Lhknee.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman3Pos = Lhankle.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman4Pos = Lhfoot.transform.position;

        var cHuman1Pos = Lhhip.transform.position;
        var subHuman1Pos = cHuman1Pos - sHuman1Pos;
        var subanimal1Pos = sAnimal1Pos + subHuman1Pos * 0.7f;
        Lahip.transform.position = subanimal1Pos;

        var cHuman2Pos = Lhknee.transform.position;
        var subHuman2Pos = cHuman2Pos - sHuman2Pos;
        var subanimal2Pos = sAnimal2Pos + subHuman2Pos * 0.5f;
        Laknee.transform.position = subanimal2Pos;

        var cHuman3Pos = Lhankle.transform.position;
        var subHuman3Pos = cHuman3Pos - sHuman3Pos;
        var subanimal3Pos = sAnimal3Pos + subHuman3Pos * 0.7f;
        Laankle.transform.position = subanimal3Pos;

        var cHuman4Pos = Lhfoot.transform.position;
        var subHuman4Pos = cHuman4Pos - sHuman4Pos;
        var subanimal4Pos = sAnimal4Pos + subHuman4Pos * 0.7f;
        Lafoot.transform.position = subanimal4Pos;

    }
}


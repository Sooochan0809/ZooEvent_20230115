using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostrackingGtail : MonoBehaviour
{
    [SerializeField]
    GameObject clavicle;
    [SerializeField]
    GameObject sholder;
    [SerializeField]
    GameObject elbow;
    [SerializeField]
    GameObject hand;

    [SerializeField]
    GameObject tail1;
    [SerializeField]
    GameObject tail2;
    [SerializeField]
    GameObject tail3;
    [SerializeField]
    GameObject tail4;

    Vector3 sHuman1Pos, sAnimal1Pos, sHuman2Pos, sAnimal2Pos, sHuman3Pos, sAnimal3Pos, sHuman4Pos, sAnimal4Pos;

    // Start is called before the first frame update
    void Start()
    {

        sAnimal1Pos = tail1.transform.position;
        sAnimal2Pos = tail2.transform.position;
        sAnimal3Pos = tail3.transform.position;
        sAnimal4Pos = tail4.transform.position;

    }

    // Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            sHuman1Pos = clavicle.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman2Pos = sholder.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman3Pos = elbow.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman4Pos = hand.transform.position;

        var cHuman1Pos = clavicle.transform.position;
        var subHuman1Pos = cHuman1Pos - sHuman1Pos;
        var subanimal1Pos = sAnimal1Pos + subHuman1Pos;
        tail1.transform.position = subanimal1Pos;

        var cHuman2Pos = sholder.transform.position;
        var subHuman2Pos = cHuman2Pos - sHuman2Pos;
        var subanimal2Pos = sAnimal2Pos + subHuman2Pos;
        tail2.transform.position = subanimal2Pos;

        var cHuman3Pos = elbow.transform.position;
        var subHuman3Pos = cHuman3Pos - sHuman3Pos;
        var subanimal3Pos = sAnimal3Pos + subHuman3Pos;
        tail3.transform.position = subanimal3Pos;

        var cHuman4Pos = hand.transform.position;
        var subHuman4Pos = cHuman4Pos - sHuman4Pos;
        var subanimal4Pos = sAnimal4Pos + subHuman4Pos;
        tail4.transform.position = subanimal4Pos;

    }
}

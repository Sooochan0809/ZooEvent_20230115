using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostrackingfootR : MonoBehaviour
{
    [SerializeField]
    GameObject Rhhip;
    [SerializeField]
    GameObject Rhknee;
    [SerializeField]
    GameObject Rhankle;
    [SerializeField]
    GameObject Rhfoot;

    [SerializeField]
    GameObject Rahip;
    [SerializeField]
    GameObject Raknee;
    [SerializeField]
    GameObject Raankle;
    [SerializeField]
    GameObject Rafoot;

    Vector3 sHuman1Pos, sAnimal1Pos, sHuman2Pos, sAnimal2Pos, sHuman3Pos, sAnimal3Pos, sHuman4Pos, sAnimal4Pos;

    // Start is called before the first frame update
    void Start()
    {

        sAnimal1Pos = Rahip.transform.position;
        sAnimal2Pos = Raknee.transform.position;
        sAnimal3Pos = Raankle.transform.position;
        sAnimal4Pos = Rafoot.transform.position;

    }

    // Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            sHuman1Pos = Rhhip.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman2Pos = Rhknee.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman3Pos = Rhankle.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman4Pos = Rhfoot.transform.position;

        var cHuman1Pos = Rhhip.transform.position;
        var subHuman1Pos = cHuman1Pos - sHuman1Pos;
        var subanimal1Pos = sAnimal1Pos + subHuman1Pos * 0.7f;
        Rahip.transform.position = subanimal1Pos;

        var cHuman2Pos = Rhknee.transform.position;
        var subHuman2Pos = cHuman2Pos - sHuman2Pos;
        var subanimal2Pos = sAnimal2Pos + subHuman2Pos * 0.5f;
        Raknee.transform.position = subanimal2Pos;

        var cHuman3Pos = Rhankle.transform.position;
        var subHuman3Pos = cHuman3Pos - sHuman3Pos;
        var subanimal3Pos = sAnimal3Pos + subHuman3Pos * 0.7f;
        Raankle.transform.position = subanimal3Pos;

        var cHuman4Pos = Rhfoot.transform.position;
        var subHuman4Pos = cHuman4Pos - sHuman4Pos;
        var subanimal4Pos = sAnimal4Pos + subHuman4Pos * 0.7f;
        Rafoot.transform.position = subanimal4Pos;

    }
}

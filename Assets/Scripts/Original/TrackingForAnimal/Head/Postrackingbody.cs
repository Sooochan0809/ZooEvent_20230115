using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postrackingbody : MonoBehaviour
{
    [SerializeField]
    GameObject Hnaval;
    [SerializeField]
    GameObject Hpelvis;

    [SerializeField]
    GameObject Anaval;
    [SerializeField]
    GameObject Apelvis;

    Vector3 sHuman1Pos, sAnimal1Pos, sHuman2Pos, sAnimal2Pos;

    // Start is called before the first frame update
    void Start()
    {

        sAnimal1Pos = Anaval.transform.position;
        sAnimal2Pos = Apelvis.transform.position;

    }

    // Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            sHuman1Pos = Hnaval.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
            sHuman2Pos = Hpelvis.transform.position;

        var cHuman1Pos = Hnaval.transform.position;
        var subHuman1Pos = cHuman1Pos - sHuman1Pos;
        var subanimal1Pos = sAnimal1Pos + subHuman1Pos;
        Anaval.transform.position = subanimal1Pos;

        var cHuman2Pos = Hpelvis.transform.position;
        var subHuman2Pos = cHuman2Pos - sHuman2Pos;
        var subanimal2Pos = sAnimal2Pos + subHuman2Pos;
        Apelvis.transform.position = subanimal2Pos;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateangleTail : MonoBehaviour 
{
    [SerializeField]
    GameObject shoulder;
    [SerializeField]
    GameObject elbow;
    [SerializeField]
    GameObject hand;
    [SerializeField]
    GameObject handtip;

    [SerializeField]
    GameObject tail1;
    [SerializeField]
    GameObject tail2;
    [SerializeField]
    GameObject tail3;

    Vector3 sPos, ePos, hPos, htPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        sPos = shoulder.transform.position;
        ePos = elbow.transform.position;
        hPos = hand.transform.position;
        htPos = handtip.transform.position;

        var shoulderElbow = Quaternion.LookRotation(shoulder.transform.position, elbow.transform.position);
        var elbowHand = Quaternion.LookRotation(ePos = elbow.transform.position, hand.transform.position);
        var handfinger = Quaternion.LookRotation(ePos = hand.transform.position, handtip.transform.position);

        tail1.transform.rotation = shoulderElbow;
        tail2.transform.rotation = elbowHand;
        tail3.transform.rotation = handfinger;

        //Šm”F—p
        //Debug.Log("kata" + shoulderElbow.ToEuler());
        //Debug.Log("hizi" + elbowHand.ToEuler());
        //Debug.Log("yubi" + handfinger.ToEuler());

        tail1.transform.rotation = shoulder.transform.rotation * tail1.transform.rotation;
        transform.rotation = elbow.transform.rotation * tail2.transform.rotation;
        tail3.transform.rotation = hand.transform.rotation * tail3.transform.rotation;
    }
}
    
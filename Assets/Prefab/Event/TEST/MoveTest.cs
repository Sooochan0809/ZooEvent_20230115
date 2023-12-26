using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    private Vector3 Cubepos;
    // Start is called before the first frame update
    void Start()
    {
        Cubepos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 5.0f + Cubepos.x, Cubepos.y, Cubepos.z);
    }
}

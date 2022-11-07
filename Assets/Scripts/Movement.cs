using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("w"))
        {
            transform.localPosition += Vector3.forward;
        }
        if (Input.GetButton("s"))
        {
            transform.localPosition += Vector3.back;
        }
        if (Input.GetButton("a"))
        {
            transform.localPosition += Vector3.right;
        }
        if (Input.GetButton("d"))
        {
            transform.localPosition += Vector3.left;
        }
    }
}

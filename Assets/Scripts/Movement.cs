using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    private int currentSpeed;
    private const int speedForward = 5;
    private const int speedBackward = 3;
    private int turnSpeed = 60;
    private Vector3 initialPos = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        initiateChar();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Forward o backward movement
        if (verticalInput < 0)
        {
            currentSpeed = speedBackward; //get backward speed
        }
        else {
            currentSpeed = speedForward; //gt forward speed
        }
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime * verticalInput);
        
        //Lateral movement
        if (Input.GetKey(KeyCode.D)||(Input.GetKey(KeyCode.A)))
        {
             transform.Translate(Vector3.right * currentSpeed * Time.deltaTime * horizontalInput);
        }
        //Rotattion movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
           transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        }

        //Reset position
        if (Input.GetKeyDown(KeyCode.R))
        {
            initiateChar();
        }

    }

    //Initiate character
    private void initiateChar()
    {
        transform.SetPositionAndRotation(initialPos, Quaternion.Euler(0, -90, 0));
    }


}

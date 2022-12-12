using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //VARIABLES
    private float verticalInput; 
    private float horizontalInput;
    private int currentSpeed; //Player current speed
    private const int speedForward = 5; //Forward speed
    private const int speedBackward = 3; //Backward speed
    private int turnSpeed = 100; //Turnspeed
    private Vector3 initialPos = new Vector3(0,0,0); //Initial position

    // Start is called before the first frame update
    void Start()
    {
        initiateChar();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); //Read vertical input
        horizontalInput = Input.GetAxis("Horizontal");//Read horizontal input

        //Forward o backward movement
        if (verticalInput < 0)
        {
            currentSpeed = speedBackward; //get backward speed
        }
        else {
            currentSpeed = speedForward; //get forward speed
        }
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime * verticalInput);
        
        //Rotation movement
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        //Reset position
        if (Input.GetKeyDown(KeyCode.R))
        {
            initiateChar();
        }

    }

    //Initiate character
    private void initiateChar()
    {
        transform.SetPositionAndRotation(initialPos, Quaternion.Euler(0, 180, 0));
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VARIABLES
    private float verticalInput; 
    private float horizontalInput;
    private float currentSpeed; //Player current speed
    private float speedForward = 5f; //Forward speed
    private float speedBackward = 3f; //Backward speed
    private float turnSpeed = 100; //Turnspeed
    private Vector3 initialPos = new Vector3(0,0,0); //Initial position
    private bool activatePointer = false;

    // Start is called before the first frame update
    void Start()
    {
        InitiateChar();
        Debug.Log($"Player Controls:\nMovement: WASD or ArrowKeys\nActivate search coin function: R"); //Display player controls
        Debug.Log($"Objectives: Collect 30 coins and reach the GOAL"); //Display player controls
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); //Read vertical input
        horizontalInput = Input.GetAxis("Horizontal");//Read horizontal input

        //Forward or backward movement
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

        //Search coins controller
        if (Input.GetKeyDown(KeyCode.R))
        {
            activatePointer = !activatePointer; //Toggle on/off the search coin function
            transform.GetChild(4).gameObject.SetActive(activatePointer); //Set active Arrow pointer (child(4))    
        }
    }

    //Initiate character
    private void InitiateChar()
    {
        transform.SetPositionAndRotation(initialPos, Quaternion.Euler(0, 180, 0));
    }
}

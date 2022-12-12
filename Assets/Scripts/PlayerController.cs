using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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
            findClosestCoin();
        }

    }

    //Initiate character
    private void initiateChar()
    {
        transform.SetPositionAndRotation(initialPos, Quaternion.Euler(0, 180, 0));
    }

    //FUnction that finds the closes collectable
    private GameObject findClosestCoin() {
        
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Collectables"); //get all object with tag "Collectables" in scene

        GameObject closest = null; //Initiate variable gameObject
        float distance = Mathf.Infinity; //Store the highest posible value first
        
        Vector3 position = transform.position;
        //Check for every gameobject in 
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            //Check if the new gameObject distance is lower of the current one stored
            if (curDistance < distance)
            {
                closest = go; //Asign the closest gameObject
                distance = curDistance; //get the new closest distance
            }
        }
        return closest; //return the closest gameObject found
    }


}

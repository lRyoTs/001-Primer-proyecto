using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private GameObject targetLook; //store the coin to target
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        targetLook = FindClosestCoin(); //Stores the closest coin
        gameObject.transform.LookAt(targetLook.transform); //Arrow targets the closest coin found
    }

    //Function that finds the closes collectable
    private GameObject FindClosestCoin()
    {

        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Collectables"); //get all object with tag "Collectables" in scene

        GameObject closest = null; //Initiate variable gameObject
        float distance = Mathf.Infinity; //Store the highest posible value first
        Vector3 position = transform.position; //Get player position

        //Check for every gameobject with tag "Collectables" 
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCollision : MonoBehaviour
{
    //VARIABLES
    private Vector3 respawnPos; //Store the position to spawn if killed
    private Quaternion respawnRot; //Store the rotation to spawn if killed
    private int playerLife = 10;
    private int collectCounter = 0; //counts the collectables collected
    private Collider m_Collider; //Stores gameObject Collider

    private void Start()
    {
        //Fetch the gameObject's Collider (it has to have a Collider component)
        m_Collider = transform.GetChild(0).GetComponent<Collider>();
    }
    //Function that check player collisions
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Collectables") {
            Destroy(other.gameObject); //Destroy collectable
            collectCounter++; //Increase by 1 counter
            Debug.Log($"You have {collectCounter}/30 coins");
        }
        
        //Check colision with Traps
        if (other.gameObject.tag == "Traps")
        {
            m_Collider.enabled = false; //Toggle the Collider off when killed
            playerLife--; //Reduce player life by 1
            Destroy(other.gameObject); //Destroy trap
            Debug.Log($"You have {playerLife} lives left");
            
            if (playerLife < 1)
            {
                gameObject.SetActive(false);
                Debug.Log($"GAME OVER"); //Display Game Over
                Time.timeScale = 0; //Freeaze Game
            }
            else {
                transform.position = respawnPos; //Move gameObject to latest checkpoint
                transform.rotation = respawnRot;         
            }
            m_Collider.enabled = true; //Toggle the Collider on when respawned
        }

        //Check colision with Checkpoint
        if (other.gameObject.tag == "Checkpoint")
        {
            Debug.Log($"Checkpoint saved");
            respawnPos = transform.position; //Update respawn to latest checkpoint
            respawnRot = transform.rotation; 
        }

        if (other.gameObject.tag == "Finish") {
            if (collectCounter < 30) //Check if the player collected all coins
            {
                Debug.Log($"You do NOT have all the COINS {collectCounter}/30");
            }
            else {
                Debug.Log($"Congratulations, YOU WON"); //Display win message
                Time.timeScale = 0; //freeze game
            }
        }
    }
}

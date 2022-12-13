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
            gameObject.SetActive(false);
            playerLife--; //Reduce player life by 1
            Destroy(other.gameObject); //Destroy trap
            
            if (playerLife < 1)
            {
                //gameObject.SetActive(false); //Desactivate player
                Debug.Log($"GAME OVER"); //Display Game Over
                Time.timeScale = 0; //Freeaze Game
            }
            else {
                transform.position = respawnPos; //Move gameObject to latest checkpoint
                transform.rotation = respawnRot;
                gameObject.SetActive(true);
                Debug.Log($"You have {playerLife} lives left");
            }
        }

        //Check colision with Checkpoint
        if (other.gameObject.tag == "Checkpoint")
        {
            Debug.Log($"You have collided with {other.gameObject.name}");
            respawnPos = transform.position; //Update respawn to latest checkpoint
            respawnRot = transform.rotation; 
        }

        if (other.gameObject.tag == "Finish") {
            if (collectCounter < 30) //Check if the player collected all coins
            {
                Debug.Log($"You do NOT have all the COINS {collectCounter}/30");
            }
            else {
                Debug.Log($"Congratulations, YOU WON");
                Time.timeScale = 0; //freeze game
            }
        }
    }
}

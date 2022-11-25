using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCollision : MonoBehaviour
{
    //Function that check player collisions
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"You have collided with {other.collider.name}");
        if (other.gameObject.tag == "Collectables") {
            Debug.Log($"You have collided with {other.gameObject.name}");
            Destroy(other.gameObject);
        }
    }
}

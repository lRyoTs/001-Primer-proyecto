using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCollision : MonoBehaviour
{
    private float pushSpeed = 50f;
    //Function that check player collisions
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"You have collided with {other.collider.name}");
        if (other.gameObject.tag == "Collectables") {
            Debug.Log($"You have collided with {other.gameObject.name}");
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Obstacle") {
            //transform.Translate(Vector3.back * );
            Destroy(other.gameObject);
        }
    }
}

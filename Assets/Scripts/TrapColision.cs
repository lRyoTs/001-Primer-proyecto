using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapColision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log($"You have collided with {other.gameObject.name}");
            Destroy(gameObject);
        }
    }
}

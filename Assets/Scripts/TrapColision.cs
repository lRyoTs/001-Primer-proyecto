using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapColision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle") //CHeck if the trap collided with Obstacle
        {
            Destroy(gameObject);
        }
    }
}

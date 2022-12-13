using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMov : MonoBehaviour
{
    private float speedRot = 100f;

    // Update is called once per frame
    void Update()
    {
        CoinMovement();
    }

    private void CoinMovement() {
        transform.RotateAround(transform.position, Vector3.up, speedRot * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMov : MonoBehaviour
{
    private float speedRot = 100f;
    private bool hasHorizontal = false;
    private bool hasVertical = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinMovement();
    }

    private void coinMovement() {
        transform.RotateAround(transform.position, Vector3.up, speedRot * Time.deltaTime);
        if (hasHorizontal) {
            transform.Translate(Vector3.forward * 10f * Time.deltaTime);
        }

        if (hasVertical) {
        
        }
    }
}

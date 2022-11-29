using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private bool isRock = false;
    [SerializeField] private bool isTrap = false;
    [SerializeField] private GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        if (isRock) {
            InvokeRepeating("InitiateRock", 10f, 2f);
        }

        if (isTrap) {
            InvokeRepeating("InitiateTrap", 10f, 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitiateRock() {
    
    }

    private void InitiateTrap() {
    
    }
}

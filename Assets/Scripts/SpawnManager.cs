using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject prefabs;
    [SerializeField] private float timer = 2f;
    [SerializeField] private float spawnRate = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InitiateObject",timer, spawnRate);
    }

    // Update is called once per frame
    private void InitiateObject() {
        Instantiate(prefabs,transform.position,transform.rotation);
    }
}

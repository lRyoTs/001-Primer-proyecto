using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject prefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InitiateObject", 2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitiateObject() {
        Instantiate(prefabs,transform.position,transform.rotation);
    }
}

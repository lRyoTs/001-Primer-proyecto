using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    //VARIABLES
    public int points; //Current coins obtained
    private const int maxPoints = 30; //Max numbers of coin in game
    [SerializeField] private GameObject coin; //store the coin to instatiate

    // Start is called before the first frame update
    void Start()
    {
        //initiateCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function that initiate the Max numbers of coins
    private void initiateCoins() {
        for (int i = 0;i<30 ;i++) {
            Instantiate(coin,RandomSpawnPos(),Quaternion.identity);
        }
    }

    private Vector3 RandomSpawnPos() {
        float randomX = Random.Range(0,transform.position.x);
        float randomZ = Random.Range(0,transform.position.z);
        float randomY = Random.Range(0, 1);

        return new Vector3(randomX, randomY, randomZ);
    }
}

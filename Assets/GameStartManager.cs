using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartManager : MonoBehaviour {


    public GameObject AsteroidIron;
    public int AmmountOfIron;
    public GameObject AsteroidGold;
    public int AmmountOfGold;
    // Here, we spawn asteroids.
    void Start()
    {
        SpawnAsteroids(AsteroidIron, AmmountOfIron);
        SpawnAsteroids(AsteroidGold, AmmountOfGold);
    }

    // SpawnAsteroids takes in two argumnts, the asteroid we wanna spawn, and the ammount we want to spawn it by
    void SpawnAsteroids(GameObject asteroidToSpawn,int ammountToSpawn)
    {
        int i = 0;
        while(i != ammountToSpawn)
        {
            // Because asteroids will move themselves, we spawn them at position 0.
            Instantiate(asteroidToSpawn,transform.position,transform.rotation);
            i++;
        }
    }

	
	// Update is called once per frame
	void Update () {
        
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour {

    public int asteroidAmmount;
    public float asteroidMiningDiffuculty;
    public Asteroid asteroid;

    //Using Scriptable Objects, we have an asteroid information class thingy send information to this.
    // Use this for initialization


    void Start()
    {
        // Custom function to move. We want to spawn outside of a circle around the base. This does it randomly enough.
        MoveAsteroid();
        asteroidAmmount = asteroid.materialAmmount;
        asteroidMiningDiffuculty = asteroid.miningDifficulty;
	}

        // Get a random number between 0 and 360. This becomes our forward direction.
    void MoveAsteroid()
    {
        float direction = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(transform.rotation.x,direction, transform.rotation.z);
        // Then we move forward by a number between 5 and 10.
        float movement = Random.Range(5, 10);
        transform.Translate(Vector3.forward * movement);
        transform.position = new Vector3 (transform.position.x, Mathf.Sin(Random.Range(-1, 1)), transform.position.z);
    }

}

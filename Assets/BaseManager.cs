using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager : MonoBehaviour {

    public Collider[] asteroids;
    public GameObject[] listOfDrones;


    public List<Collider> listOfAsteroids;
    public int listOfAsteroidsIndex = 0;

	// Use this for initialization
	void Start () {
        // Gathers a list of friendly drones in the area.
        listOfDrones = GameObject.FindGameObjectsWithTag("FriendlyDrones");
        for (int i = 0; i < listOfDrones.Length; i++)
        {
            Debug.Log(listOfDrones[i].name);
        }


        // We gather every object within a certain area.
        asteroids = Physics.OverlapSphere(transform.position, 5);
        //int i = 0;
        int x = asteroids.Length;

        // For every asteroid within that area, we get all of the asteroids.
        foreach (Collider potentalAsteroid in asteroids)
        {
            if(potentalAsteroid.tag == "Asteroid")
            {
                listOfAsteroids.Add(potentalAsteroid);
            }
        }

        foreach(Collider Asteroid in listOfAsteroids)
        {
            print(Asteroid.gameObject.name);
        }

        listOfDrones[0].GetComponent<DroneController>().SetDestination(listOfAsteroids[0].gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

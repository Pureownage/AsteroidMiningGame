using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager : MonoBehaviour {

    public Collider[] asteroids;
    public GameObject[] listOfDrones;

    public Queue<Jobs> listOfJobs;


    public GameObject[] listOfAsteroids1;

    public List<Collider> listOfAsteroids;
    public int listOfAsteroidsIndex = 0;

	// Use this for initialization
	void Start () {
        // Gathers a list of friendly drones in the area.
        listOfDrones = GameObject.FindGameObjectsWithTag("FriendlyDrones");
        for (int i = 0; i < listOfDrones.Length; i++)
        {

        }


        // We gather every object within a certain area.
        asteroids = Physics.OverlapSphere(transform.position, 20);
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

        }

        //        listOfDrones[0].GetComponent<DroneController>().SetDestination(listOfAsteroids[0].gameObject);
	}
	
    public void ScanForAsteroids()
    {
        FindClosestAsteroid(listOfAsteroids);
    }


    GameObject FindClosestAsteroid(List<Collider> asteroids)
    {
        Debug.Log(asteroids[0].name);
        GameObject tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach(Collider t in asteroids)
        {
            float dist = Vector3.Distance(t.transform.position, currentPos);
            Debug.Log(t.name);
            Debug.Log(dist);
            if (dist < minDist)
            {
                tMin = t.gameObject;
                minDist = dist;

            }
        }
        print("The Clostest Asteroid is : " + tMin.transform.name);
        return tMin;
    }

    void CreateJob()
    {
       // Jobs NewJob = new Jobs(listOfAsteroids[]);
    }


	// Update is called once per frame
	void Update () {
		
	}
}

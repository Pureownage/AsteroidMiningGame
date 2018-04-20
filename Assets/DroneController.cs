using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class DroneController : MonoBehaviour {

    public Vector3 destination;
    public GameObject asteroid;
    NavMeshAgent agent;

    Jobs currentJob;

    // This code is mostly for testing purposes and will likely be removed.
    // Use this for initialization
    void Awake () {
        agent = GetComponent<NavMeshAgent>();
        //asteroid = GameObject.FindGameObjectWithTag("Asteroid");
        //destination = asteroid.transform.position;
        //agent.destination = destination;
	}


    void CheckForJobs()
    {
        
    }

    // Set the destination.
    public void SetDestination(GameObject Destination)
    {
        asteroid = Destination;
        destination = Destination.transform.position;
        agent.destination = destination;
    }

	// Update is called once per frame
	void Update () {
        if (asteroid != null)
        {
            if (Vector3.Distance(destination, asteroid.transform.position) > 0.001f)
            {
                destination = asteroid.transform.position;
                agent.destination = destination;
            }
        }
	}
}

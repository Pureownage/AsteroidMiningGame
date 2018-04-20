using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jobs
{

    AsteroidManager targetAsteroid;

    float asteroidMiningTime;
    Vector3 targetLocation;




    void GetAsteroidData(AsteroidManager target)
    {
        targetLocation = target.transform.position;
        asteroidMiningTime = target.asteroidMiningDiffuculty;
    }



}


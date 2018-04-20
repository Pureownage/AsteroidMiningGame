using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAsteroids : MonoBehaviour {

	public void FindAsteroid()
    {
        FindObjectOfType<BaseManager>().ScanForAsteroids();
    }
}

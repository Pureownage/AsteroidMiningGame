using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float direction = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(transform.rotation.x,transform.rotation.y + direction, transform.rotation.z);
        float movement = Random.Range(5, 10);
        transform.Translate(Vector3.forward * movement);
        }
	
	// Update is called once per frame
	void Update () {
		
	}
}

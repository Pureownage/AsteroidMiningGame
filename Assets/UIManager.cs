using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponentInChildren<Text>();
        text.text = "Test";
    }
	
	// Update is called once per frame
	void Update () {

	}
}

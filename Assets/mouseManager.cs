using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseManager : MonoBehaviour {

    public GameObject selectedObject;
    public Material selectedObjectMaterial;
    Color selectedObjectColor;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        // If mouse 1 is being held down
        if (Input.GetMouseButtonDown(0))
        {
            // Shoot out a ray, and get the ray information
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInformation;
            if (Physics.Raycast(ray, out hitInformation))
            {
                // If we are over an object, jump into SelectObject, which looks at the thing we hit and gets its information.
                Debug.Log("Mouse is currently over: " + hitInformation.collider.name);
                GameObject hitObject = hitInformation.transform.root.gameObject;
                selectedObjectColor = hitObject.GetComponent<Renderer>().material.color;
                SelectObject(hitObject);
            }
            else
            {
                // Otherwise, we clear the selection.
                ClearSelection();
            }
        }
	}

    void ClearSelection()
    {
        // Here, we set the selectedobject to null, and we change the object to its original colour.
        if (selectedObject == null)
            return;
        Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            //selectedObject.GetComponent<AsteroidManager>().RestoreMaterial();
            r.material.color = selectedObjectColor;
           // Material m = selectedObjectMaterial;
          //  m = selectedObjectMaterial;
            //r.material = m;
           // r.material = selectedObjectMaterial;
        }
        selectedObject = null;
    }


    // Here, we select the object.
    void SelectObject(GameObject obj)
    {
        if (selectedObject != null)
        {
            if (obj == selectedObject)
                return;
            ClearSelection();

        }
        selectedObject = obj;


        // And change its colour to green, to represent the fact that it has been selected.
        Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            //selectedObjectMaterial = r.material;
            Material m = r.material;
            m.color = Color.green;
            r.material = m;
        }
    }
}

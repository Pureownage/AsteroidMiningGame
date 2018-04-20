using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Test: MonoBehaviour
{
    public Renderer rend;
    public bool Render;

    // Test code, please ignore.
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Toggle the Object's visibility each second.
    void Update()
    {
        if(Render == true)
        {
            rend.enabled = true;
        } else
        {
            rend.enabled = false;
        }
    }

}
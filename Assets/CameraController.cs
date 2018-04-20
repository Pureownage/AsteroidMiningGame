using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    public float sensitivity = 1.0f;

    public Camera MainCamera;
    public float cameraFov;

    public float minFov = 30f;
    public float maxFov = 90f;
    public float cameraSpeed;

	// Use this for initialization
	void Start () {
        cameraSpeed = Time.deltaTime;
        MainCamera = GetComponentInChildren<Camera>();
        cameraFov = MainCamera.fieldOfView;
    }
	
	// Update is called once per frame
	void Update () {

        // Here, we move the camera by using units axis system.
        // This section of code will use the mousewheel axis to change the cameras FoV.
        cameraFov = cameraFov - Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        cameraFov = Mathf.Clamp(cameraFov, minFov, maxFov);
        MainCamera.fieldOfView = cameraFov;


        // And here, we use the axis commands to move the camera.
        // This means we can use both wasd, the arrow keys or a joypad to move the camera north, south, east or west.
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(translation, 0, -rotation);
      //  transform.Rotate(0, rotation, 0);
    }
}

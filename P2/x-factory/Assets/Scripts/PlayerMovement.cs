using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float mouseSensitivity = 5.0f;
    public float UpDownRange = 60.0f;
    public float verticalRotation = 0;

	// Use this for initialization
	void Start () {

        Cursor.lockState = CursorLockMode.Locked;


		
	}
	
	// Update is called once per frame
	void Update () {

        float rotateSide = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotateSide, 0);

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -UpDownRange, UpDownRange);
         Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        if (Input.GetKey("l"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        float forwardSpeed = Input.GetAxis("Vertical") * moveSpeed;
        float sidewardSpeed = Input.GetAxis("Horizontal") * moveSpeed;

        Vector3 speed = new Vector3(sidewardSpeed, 0, forwardSpeed);

        speed = transform.rotation * speed;

        CharacterController Chc = GetComponent<CharacterController>();

        Chc.SimpleMove(speed);



    }
}

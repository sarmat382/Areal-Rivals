using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 45.0f; // Adjust the speed as needed

    void Update()
    {
        // Get the current rotation of the object
        Vector3 currentRotation = transform.rotation.eulerAngles;

        // Check for input to rotate left ("A" key) or right ("D" key)
        if (Input.GetKey("a"))
        {
            currentRotation.z += rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("d"))
        {
            currentRotation.z -= rotationSpeed * Time.deltaTime;
        }

        // Apply the new rotation
        transform.rotation = Quaternion.Euler(currentRotation);
    }
}
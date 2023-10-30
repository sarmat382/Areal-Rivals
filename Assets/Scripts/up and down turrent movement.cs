using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnXAxis : MonoBehaviour
{
    public float rotationSpeed = 30.0f;

    void Update()
    {
        // Check for key input
        if (Input.GetKey(KeyCode.W))
        {
            // Rotate the object around the X-axis when "W" is pressed
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // Rotate the object around the X-axis when "S" is pressed
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        }
    }
}
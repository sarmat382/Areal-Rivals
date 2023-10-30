using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5.0f;   // Adjustable movement speed

    void Update()
    {
        // Move forward
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }
}
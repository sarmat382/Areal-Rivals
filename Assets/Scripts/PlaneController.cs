using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {
    [Header("Plane stats")]
    [Tooltip("How much does the thrittle ramps up or down")]
    public float throttleIncrement = 0.1f;
    [Tooltip("Maximum engine trtust when 100% throttle")]
    public float maxThrottle = 200f;
    [Tooltip("how responsive the plane is when rolling piching and yawing")]
    public float responsiveness = 200f;


    private float throttle;
    private float roll;
    private float pich;
    private float yaw;

    private float responseModyfier {//Vaule used to tweak responsiveness to suit plane's mass.
        get {
            return (rb.mass / 10f) * responsiveness;
        }
    }

    Rigidbody rb;

    private void Awake() {
        
        rb = GetComponent<Rigidbody>();

    }

    private void HandleInputs() {
        
        // Set rotatiolan values from our axis inputs.
        roll = Input.GetAxis("Roll");
        pich = Input.GetAxis("Pich");
        yaw = Input.GetAxis("Yaw");

     

    }

    private void Update() {

        HandleInputs(); 


    }

    private void FixedUpdate() {

        // Apply forces to our plane.
        rb.AddForce(transform.forward * maxThrottle * throttle);
        rb.AddTorque(transform.up *yaw * responseModyfier);
        rb.AddTorque(transform.right *pich * responseModyfier);
        rb.AddTorque(transform.forward *roll * responseModyfier);

    }


    public class ForwardMotion : MonoBehaviour
{
    public float speed = 5.0f; // Adjust the speed as needed
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check for input to move the object forward
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 forwardForce = transform.forward * speed;
            rb.AddForce(forwardForce);
        }
    }
}


} 
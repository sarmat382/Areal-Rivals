using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class Bullet : MonoBehaviour
{
    public float life = 31000;
 
    
 
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}

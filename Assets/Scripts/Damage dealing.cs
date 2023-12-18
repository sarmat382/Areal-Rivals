using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagedealing : MonoBehaviour
{
    public float amount = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Health health))
        {
            health.DecreaseHealth(amount);
            Debug.Log("Hit");
        }

    }

    private void OntrTggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Health health))
        {
            health.DecreaseHealth(amount);
        }

    }
}

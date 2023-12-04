using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misslelouncher : MonoBehaviour
{
    Transform _Player;
    float dist;
    public float howClose;
    public Transform head, barrel;
    public GameObject _projectile;
    public float fireRate, nextFire;
    // Start is called before the first frame update
    void Start()
    {
        _Player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(_Player.position, transform.position);
        if(dist <= howClose)
        {
            head.LookAt(_Player);
            if(Time.time >= nextFire)
            {
                nextFire = Time.time + 1f / fireRate;
                 shoot();
            }
           
        }
    }

    void shoot()
    {
        GameObject clone = Instantiate(_projectile, barrel.position, transform.rotation);
         clone.GetComponent<Rigidbody>().AddForce(transform.forward * 200000);
         Destroy(clone, 30);
    }
}

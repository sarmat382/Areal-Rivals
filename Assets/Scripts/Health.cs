using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100;

    public float AddHealth(float amount)
    {
        return health += amount;
    }

    public void DecreaseHealth(float amount) //nie wiem czemu tu jest parametr skoro go nie wykorzystujewsz w metodzie
    {
         health = health - amount;

        if (health <= 0)
        {
            health = 0;
            Debug.Log("Skill issue");
            

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy: MonoBehaviour
{
    public float health = 4f;
    public GameObject deathEffect;

  

    private void OnCollisionEnter2D(Collision2D colInfo)
    {
        if (colInfo.collider.tag == "Player")
        {
            Debug.Log("level won");
            Die();
        }
    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}


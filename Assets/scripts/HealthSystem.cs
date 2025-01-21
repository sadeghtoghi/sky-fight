using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem : MonoBehaviour
{
    public float health=100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var dammageDealer = collision.GetComponent<DammageDealer>();
        if (dammageDealer != null)
        {
            TakeDammage(dammageDealer.GetDammage());
            dammageDealer.DammageDelt();
        }
         
    }

    private void TakeDammage(float getDammage)
    {
        health -= getDammage;
        if (health < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //
    }
}

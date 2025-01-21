using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField] GameObject projectileprefab;
    [SerializeField] float projectilespeed;
    [SerializeField] float lifetime;
    public bool isFiring=false;
    
    private void Update()
    {
        if (isFiring)
        {
            StartCoroutine(FireContinuesly());
        }
        else
        {
            StopCoroutine(FireContinuesly());
        }
    }

    public void shoot()
    {
        Instantiate(projectileprefab,transform.position, Quaternion.identity);
    }

    private IEnumerator FireContinuesly()
    {
        while (true) 
        {
            shoot();
            yield return new WaitForSeconds(.5f);

        }
    }
}

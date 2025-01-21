using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecttile : MonoBehaviour
{
    public float movementSpeed = 4;
    private void Move()
    {
        transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
    }
    private void Update()
    {
        Move();
    }
}

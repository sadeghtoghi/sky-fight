using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DammageDealer : MonoBehaviour
{
    [SerializeField]
    private float Dammage = 10;

    public float GetDammage()
    {
        return Dammage;
    }
    public void DammageDelt()
    {
        Destroy(gameObject);
    }
}

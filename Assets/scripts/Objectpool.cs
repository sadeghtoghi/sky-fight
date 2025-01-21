using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectpool : MonoBehaviour
{
    public int count;
    public GameObject EnemyPrefab;
    List<GameObject> objectsInPool;
    public static Objectpool instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        objectsInPool= new List<GameObject>();
        for (int i = 0; i < count; i++)
        {
            var temp = Instantiate(EnemyPrefab);
            temp.transform.SetParent(transform, false);
            temp.SetActive(false);
            objectsInPool.Add(temp);
        }
    }
    public GameObject Get()
    {
        foreach (var obj in objectsInPool)
        {
            if (obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }
        return null;
    }

    public void Return(GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.SetParent(transform);
        obj.transform.position = transform.position;
    }
}

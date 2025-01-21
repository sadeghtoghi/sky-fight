using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Waveconfig config;
    public Transform WaypointParent;

    private void Start()
    {
        //Spawnenemies();
        StartCoroutine(spawnEnemyWithDelay());
    }
    private IEnumerator spawnEnemyWithDelay()
    {
        foreach (EnemySpawnConfig enemy in config.enemyPrefabs)
        {
            for (int i = 0; i < enemy.count; i++)
            {
                GameObject created = Instantiate(enemy.enemyPrefab);
                PathFinfing pf = created.GetComponent<PathFinfing>();
                pf.init(WaypointParent,config.GetMovementspeed());
                yield return new WaitForSeconds(config.spwanDeley);
            }
            yield return new WaitForSeconds(config.innerDelay);

        }
    }
    private void Spawnenemies()
    {
        
    }
}
 
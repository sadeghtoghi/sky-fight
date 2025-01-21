using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemySpawnConfig
{
    public GameObject enemyPrefab;
    public int count;
}

[CreateAssetMenu(menuName ="config/waveconfig",fileName ="Waveconfig")]
public class Waveconfig : ScriptableObject
{
    [SerializeField]
    private float Movementspeed;
    public List<EnemySpawnConfig> enemyPrefabs;
    public float spwanDeley;
    public float innerDelay;
     
   /* [SerializeField]
    private List<Transform> waypoints;  */



     public float GetMovementspeed()
    {
        return Movementspeed;
    }
  /* public List<Transform> GetWaypoints()
    {
        return waypoints;
    }*/
}

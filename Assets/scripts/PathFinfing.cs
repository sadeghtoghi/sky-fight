using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinfing : MonoBehaviour
{
    public Transform WaypointParent;
    public List<Transform> Waypoints;
    int currentWayPointIndex = 0;

    bool initilized=false;
    float Speed;
    public void init(Transform _waypointparent, float speed)
    {
        WaypointParent = _waypointparent;
        Speed = speed;
        if (WaypointParent == null) { return; }
        GetAllWayPoint();
        if (Waypoints.Count >0)
        {
            transform.position = Waypoints[0].position;

        }
        initilized = true;
    }

    private void Update()
    {
        if (initilized == false) return;
        FollowPath();
    }
    void GetAllWayPoint()
    {
        Waypoints=new List<Transform>();
        foreach (Transform child in WaypointParent) 
        {
            Waypoints.Add(child);

        }
    }

    void FollowPath()
    {
        if (currentWayPointIndex < Waypoints.Count)
        {
            float delta = 2 * Time.deltaTime;
            Vector3 target = Waypoints[currentWayPointIndex].position;
            transform.position = Vector3.MoveTowards(transform.position, target, delta);
            if(transform.position==target)
            {
                currentWayPointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

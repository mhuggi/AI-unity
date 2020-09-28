using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAI : MonoBehaviour
{
    //GameObject[] waypoints;
    public List<GameObject> waypoints;
    int wpIndex = 0;
    UnityEngine.AI.NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        //waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        nav.SetDestination(waypoints[wpIndex].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[wpIndex].transform.position) <= 0.1f) {
            wpIndex++;

            if(wpIndex >= waypoints.Count) {
                wpIndex = 0;
        }
            nav.SetDestination(waypoints[wpIndex].transform.position);


        } 

        


        
        
    }
}

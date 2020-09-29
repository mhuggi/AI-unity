using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : StateMachineBehaviour
{
    GameObject[] waypoints;
    int wpIndex = 0;
    GameObject me;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
     waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
     me = animator.gameObject;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       Vector3 direction = waypoints[wpIndex].transform.position - me.transform.position;
       me.transform.rotation = Quaternion.Slerp(me.transform.rotation, Quaternion.LookRotation(direction), 0.04f);

       if (Vector3.Distance(me.transform.position, waypoints[wpIndex].transform.position) > 0.1f) {
           me.transform.Translate(0, 0, 0.03f);
       } else {
           if (wpIndex < (waypoints.Length -1)) {
               wpIndex++;
           } else {
               wpIndex = 0;
           }
       }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : RobotFSM
{
    public GameObject[] waypoints;
    public int currentWaypoint;

    private void Awake()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
    }

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        currentWaypoint = 0;
        agent.SetDestination(waypoints[currentWaypoint].transform.position);
    }
}

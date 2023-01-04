using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobotFSM : StateMachineBehaviour
{
    public GameObject robot;
    public NavMeshAgent agent;
    public GameObject player;

    public float speed = 2f;
    public float rotSpeed = 2f;
    public float accuracy = 3f;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        robot = animator.gameObject;
        player = robot.GetComponent<RobotAIController>().player;
        agent = robot.GetComponent<NavMeshAgent>();
    }
}

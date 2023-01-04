using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : RobotFSM
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        robot.GetComponent<RobotAIController>().StartShooting();
        agent.speed = 0;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        robot.transform.LookAt(player.transform.position);
    }
    
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        robot.GetComponent<RobotAIController>().StopShooting();
        agent.speed = 2f;
    }
}

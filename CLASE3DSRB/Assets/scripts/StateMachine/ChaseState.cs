using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
    public float chaseSpeed = 3.5f;
    public float AttackDistance;
    public float IdleDistance;
    public State idleState;
    public State attacksState;

    public override State RunCurrentState()
    {
        if (Vector3.Distance(transform.position, player.position) > IdleDistance)
        {
            return idleState;
        }
        else if (Vector3.Distance(transform.position, player.position) < AttackDistance)
        {
            return attacksState;
        }
        else
        {
            agent.destination = player.position;
            agent.speed = chaseSpeed;
            return this;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AttackDistance);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineBad : MonoBehaviour
{
    public enum States
    {
        chasing,
        idle,
        attacking
    }

    public States currentStates = States.idle;

    private void Update()
    {
        stateMachine();
    }

    public void stateMachine()
    {
        switch (currentStates)
        {
            case States.chasing:
                chasing();
                break;

            case States.idle:
                idle();
                break;

            case States.attacking:
                attacking();
                break;

            default:
                break;
        }
    }

    public void chasing()
    {
    }

    public void idle()
    {
    }

    public void attacking()
    {
    }
}
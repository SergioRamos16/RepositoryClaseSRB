using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOpenDoor : MonoBehaviour
{
    public Animator doorAnimator;

    private bool doorIsOpen = true;

    public void OpenCloseDoor()
    {
        doorAnimator.SetBool("OpenDoor", doorIsOpen);
        doorIsOpen = !doorIsOpen;
    }
}
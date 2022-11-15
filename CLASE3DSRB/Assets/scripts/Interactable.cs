using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent interactionEvent;

    public void Interact()
    {
        if (interactionEvent != null)
        {
            interactionEvent.Invoke();
        }
    }
}
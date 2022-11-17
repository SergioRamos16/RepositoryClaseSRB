using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DelegateTest : MonoBehaviour
{
    public delegate void DoSomething();

    public DoSomething something;
    public CountDown countDown;
    public GameObject cuboOff;
    public Light lightToTurnOn;
    public Color colorToChange;
    public MeshRenderer meshToChangeColor;
    public UnityEvent miEventoDeUnity;

    private void Start()
    {
        countDown.endCountDown += ObjectOff;
        countDown.endCountDown += ChangeColor;
        countDown.endCountDown += TurnOnLigth;
        //something = Method1;
        //something += Method2;
        //something();
    }

    public void ObjectOff()
    {
        GameObject gameObject = cuboOff.GetComponent<GameObject>();
        cuboOff.SetActive(false);
    }

    public void ChangeColor()
    {
        meshToChangeColor.material.color = colorToChange;
    }

    public void TurnOnLigth()
    {
        lightToTurnOn.enabled = true;
    }
}
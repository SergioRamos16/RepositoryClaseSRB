using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public float countDownTime;

    public delegate void OnCountDownFinish();

    public OnCountDownFinish endCountDown;

    private void Start()
    {
        StartCoroutine(CountDownCorrutine());
    }

    public IEnumerator CountDownCorrutine()
    {
        yield return new WaitForSeconds(countDownTime);
        if (endCountDown != null)
        {
            endCountDown();
        }
    }
}
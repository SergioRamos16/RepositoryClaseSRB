using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    public Transform objectToMove;
    private Transform targetDestination;
    public Transform initialPosition, finalPosition;
    public float timeToMove = 2;
    public Ease easeType;
    public float timeToWait = 2;
    private ScaleMode myScale;

    public Color targetColor;
    public Color startColor;
    public Color endColor;

    public Transform targetRotation;

    public MeshRenderer rend;
    public float timeToChangeColor;
    public float timeToWaitBeforeChangingColor;

    private void Start()
    {
        targetDestination = finalPosition;
        StartCoroutine(MyFirstCorrutine());

        rend.material.color = startColor;
        rend.material.DOColor(endColor, 4);
        objectToMove.DORotate(new Vector3(0, 90, 0), 6);
        objectToMove.DOScale(new Vector3(2, 2, 2), 4);

        StartCoroutine(MySecondCorrutine());

        targetColor = endColor;
        StartCoroutine(MyColorCorrutine());
    }

    public IEnumerator MyFirstCorrutine()
    {
        while (true)
        {
            objectToMove.DOMove(targetDestination.position, timeToMove).SetEase(easeType);
            yield return new WaitForSeconds(timeToMove);
            SwapPositions();
            yield return new WaitForSeconds(timeToWait);
        }
    }

    public IEnumerator MySecondCorrutine()
    {
        while (true)
        {
            objectToMove.DOScale(new Vector3(2, 2, 2), 4);
            yield return new WaitForSeconds(timeToWait);
            objectToMove.DOScale(new Vector3(1, 1, 1), 4);
            yield return new WaitForSeconds(timeToWait);
        }
    }

    public void SwapPositions()
    {
        if (targetDestination == finalPosition)
        {
            targetDestination = initialPosition;
        }
        else
        {
            targetDestination = finalPosition;
        }
    }

    public IEnumerator MyColorCorrutine()
    {
        while (true)
        {
            rend.material.DOColor(targetColor, timeToChangeColor);
            yield return new WaitForSeconds(timeToChangeColor);
            SwapColor();
            yield return new WaitForSeconds(timeToWaitBeforeChangingColor);
        }
    }

    public void SwapColor()
    {
        if (targetColor == endColor)
        {
            targetColor = startColor;
        }
        else
        {
            targetColor = endColor;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{
    public string cardName;

    [TextArea(5, 20)]
    public string cardDescription;

    public int cardAttack;
    public int cardDefense;
    public int cardCost;
    public Sprite cardArt;
}
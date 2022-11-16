using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public Card[] avaibleCards;

    public GameObject cardPrefab;

    public int deckSize = 10;

    public Stack<CardDisplay> cardsInDeck;

    public Transform[] handCardsPositions;

    public int cardsInHand = 0;

    private void Awake()
    {
        GenerateDeck();
    }

    private void GenerateDeck()
    {
        cardsInDeck = new Stack<CardDisplay>();

        for (int i = 0; i < deckSize; i++)
        {
            GameObject newCard = Instantiate(cardPrefab, transform.position, Quaternion.identity);
            CardDisplay cardDisplay = newCard.GetComponent<CardDisplay>();
            cardDisplay.myCard = avaibleCards[UnityEngine.Random.Range(0, avaibleCards.Length)];
            newCard.transform.SetParent(transform);
            newCard.SetActive(false);
            cardsInDeck.Push(cardDisplay);
        }
    }

    public void DrawCard()
    {
        if (cardsInHand < handCardsPositions.Length)
        {
            CardDisplay cardDrawed = cardsInDeck.Pop();
            cardDrawed.gameObject.SetActive(true);
            cardDrawed.transform.position = handCardsPositions[cardsInHand].position;
            cardsInHand++;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DrawCard();
        }
    }
}
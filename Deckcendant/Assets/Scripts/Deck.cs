﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 DECK
 The deck represents all the cards in the player owns(In playing cards this would be the entirety of the 52 cards).
 This does not include the cards generated and added into the draw pile, but does include any card the player owns regardless of what pile it is in. 
 
 TODO:
 Make a representation of a list of cards(I believe an array may actually be better than a stack in this case, but I may be wrong).
 Make methods to add cards, remove cards, get the size of the deck, and return the cards in the deck.
  
    Draw pile

TODO:
- Create a method that gives a set amount of chosen cards to another pile(or hand)
- Create a method that gives a set amount of random cards to another pile(or hand)
- Create a method that takes a set amount of cards and adds it to the pile

TODO MUCH LATER:
- Create a method that displays the whole pile either randomized or not;

 */


public class Deck : MonoBehaviour
{

    public List<GameObject> Cards;
    public bool defaultDeck;
    public Hand hand;
    private int currentCrd;
    private const int MAX_NUM_CRDS = 50;

    //private static System.Random rand = new Random(); !!!! Cannot implicitly covert Unity.Engine.Random to System.Random

    // Start is called before the first frame update
    void Start()
    {

		
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shuffle()
    {
        for(int i = Cards.Count; i > 1; i--)
        {
            //int j = rand.Next(i + 1);
           // GameObject c = Cards[j];
           // Cards[j] = Cards[i];
           // Cards[i] = c;
        }
    }

    public void AddTo(List<GameObject> cards)
    {
        foreach (GameObject c in cards)
        {
            Cards.Add(c);
        }
        
    }

    public void RemoveFrom(List<GameObject> cards)
    {
        foreach (GameObject c in cards)
        {
            Cards.Remove(c);

            /* IGNORE THIS 
            int index = IndexOf(c);
            for (int i = index; i < cards.Count() - 1; i++)
            {
                cards[i] = cards[i + 1];
            }
            cards[cards.Count()] = null;
            */
        }
    }

    // public List<GameObject> TakeFrom(int numCrds)
    //  {
    // List<GameObject> crdsToTake = DrwPile.;

    //return 
    //   }

    //  public Crd DrawCrd()
    // {


    // return crdToDrw;
    // }
}
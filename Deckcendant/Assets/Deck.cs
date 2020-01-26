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
 */

public class Deck : MonoBehaviour
{

    public struct deck
    {
        public Crd[] crds;
        public Crd topCrd;
        public Crd btmCrd;
    }
    public bool defaultDeck;
    public Hand hand;
    private int currentCrd;
    private const int MAX_NUM_CRDS = 50;
    private Random randomNumber;
    
    // Start is called before the first frame update
    void Start()
    {

		
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shuffle()
    {

    }
  //  public Crd DrawCrd()
   // {
   
      
     // return crdToDrw;
   // }
}

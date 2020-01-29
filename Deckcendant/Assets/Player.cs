using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health;
    int energy;

    public void TakeDamage(int d) { health -= d; }

   // public void PlayCard(Card c) { energy -= card.cost; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

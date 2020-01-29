using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health;
    int energy;
    int block;

    public void TakeDamage(int damage)
    {
        if (block - damage <= 0) health -= block + damage;
        else block -= damage;
    }

<<<<<<< HEAD
   // public void PlayCard(Card c) { energy -= card.cost; }
=======
    //public void PlayCard(Card c) { energy -= c.cost; }
>>>>>>> 6618ac5e3555cfccf154da9b274021d7765494a7

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

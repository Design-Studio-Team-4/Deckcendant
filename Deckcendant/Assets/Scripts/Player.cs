using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health;
    int energy;
    int block;

    public static Player instance;

    public void TakeDamage(int damage)
    {
        if (block - damage <= 0) health -= block + damage;
        else block -= damage;
    }

    public void PlayCard(Card c) { energy -= c.cost; }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

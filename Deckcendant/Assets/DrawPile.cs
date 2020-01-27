using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 DRAWPILE
The Drawpile represents the set of cards that are available to be drawn from at the start of the next turn. They are purposely displayed in a random order. 

TODO:
- Create a method that gives a set amount of chosen cards to another pile(or hand)
- Create a method that gives a set amount of random cards to another pile(or hand)
- Create a method that takes a set amount of cards and adds it to the pile

TODO MUCH LATER:
- Create a method that displays the whole pile either randomized or not;

*/
public class DrawPile : MonoBehaviour
{
    public List<GameObject> DrwPile;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Addto(List<GameObject> crds)
    {
        DrwPile.AddRange(crds);

    }
    public List<GameObject> TakeFrom(int numCrds)
    {
       // List<GameObject> crdsToTake = DrwPile.;

        //return 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

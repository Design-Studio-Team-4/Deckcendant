using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hand : MonoBehaviour
{

    public int maxCrdsInHand = 10;
    int focus = -1; //-1 means no card is in focus otherwise 0 and up are the index of the card in focus

    public List<GameObject> HandPile;
    Vector3 new_pos;
    

    // Start is called before the first frame update
    void Start()
    {
        focus = -1;
        // DrawHand(hand.Length);
        DisplayHand(HandPile.Count);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Addto(List<GameObject> crds)
    {
        //TODO: Make it so that it only adds what can fit into the hand. 
        HandPile.AddRange(crds);
       

    }
    /* public void MoveFrom(int numCrds, List <GameObject> crds, GameObject destination)
     {
          destination.GetComponent<>
     }*/
    public void RemoveFrom()
    {

    }
    public void DisplayHand(int numCrds)
    {
        float card_xseperation = 0.2f;
        float x = gameObject.transform.position.x;
        float y = gameObject.transform.position.y;
        float z = gameObject.transform.position.z;


        new_pos = new Vector3(0, 0, 0);

        for (int i = 0; i < numCrds; i++)
        {
            Debug.Log("gameobj pos = " + gameObject.transform.position);

            if (i == 0)
            {
                Debug.Log("entered if case");
                Instantiate(HandPile[i], gameObject.transform.position, gameObject.transform.rotation, gameObject.transform);
            }
            else
            {
                Debug.Log("entered else case");
                Debug.Log(card_xseperation);
                x = (x + card_xseperation);
                z = z + 0.1f;
                new_pos = new Vector3(x, y, z);
                Instantiate(HandPile[i], new_pos, gameObject.transform.rotation, gameObject.transform);

                //Debug.Log(hand[i - 1].transform.position.x);



            }
        }
    }

    private void focusOnCard(int numcrds)
    {
        for(int i = 0; i < numcrds; i++)
        {
            Crd crd = HandPile[i].GetComponent<Crd>();
            if (crd.checkFocus())
            {
                focus = i;
            }
        }
    }

    
    //public void SearchFocus()
    public int getFocus()
    {
        return focus;
    }
       
        
  
}
/*
 HAND
The Hand represents the cards that the player can choose from in the current turn. These cards are desplayed at the forefront of any combat encounter and the hand is the player's primary interface with the game. 
Due to it being the primary interface a lot of care needs to be put into the tiny details of how the hand works. 

       
TODO:
- Divide Drawhand method into a method that takes in a GIVEN number of cards from a given pile to the card array(hand), a method that GIVES out a GIVEN number of cards to a chosen pile(passes the data on and destroys object), and 
  a method that displays (instanciates) the current hand so that it places the hand nicely, accounting for the amount of cards there are and the alotted space for the hand to be displayed in.  
- Create a method which takes checks for which card the mouse is over and brings it into full veiw and displays the discription.
- Create a method that selects a card and targets an object (friend or foe); 

*/
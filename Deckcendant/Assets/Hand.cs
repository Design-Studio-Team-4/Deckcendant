using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
public class Hand : MonoBehaviour
{

    public int maxCrdsInHand = 10;

    public GameObject[] hand;
    Vector3 new_pos;


    // Start is called before the first frame update
    void Start()
    {
        DrawHand(hand.Length);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MoveCardsToHand(int numCrds, GameObject[] crds, GameObject sender)
    {

    }
    public void MoveCardsFromHand(int numCrds, GameObject[] crds, GameObject destination)
    {

    }
    void DrawHand(int numCrds)
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
                Instantiate(hand[i], gameObject.transform.position, gameObject.transform.rotation, gameObject.transform);
            }
            else
            {
                Debug.Log("entered else case");
                Debug.Log(card_xseperation);
                x = (x + card_xseperation);
                z = z + 0.1f;
                new_pos = new Vector3(x, y, z);
                Instantiate(hand[i], new_pos, gameObject.transform.rotation, gameObject.transform);

                Debug.Log(hand[i - 1].transform.position.x);



            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hand : MonoBehaviour
{

    public int maxCrdsInHand = 10;
    int focus = -1; //-1 means no card is in focus otherwise 0 and up are the index of the card in focus
    public enum State
    {
        busy,
        waitingForPlayer,
    }
    State state;
    public List<GameObject> HandPile;
    public GameObject CardPrefab;
    Vector3 new_pos;
    

    // Start is called before the first frame update
    void Start()
    {
        float card_xseperation = 0.2f;
        float x = gameObject.transform.position.x;
        float y = gameObject.transform.position.y;
        float z = gameObject.transform.position.z;
        focus = -1;
        
        DisplayHand(HandPile.Count);
        for(int i = 0; i < HandPile.Count; i++)
        {
            if ( i == 0)
            {
                HandPile[i] = Instantiate(CardPrefab, gameObject.transform.position, gameObject.transform.rotation, gameObject.transform);
            } else
            {
                Debug.Log("entered else case");
                Debug.Log(card_xseperation);
                x = (x + card_xseperation);
                z = z + 0.1f;
                new_pos = new Vector3(x, y, z);
                HandPile[i] = Instantiate(CardPrefab, new_pos, gameObject.transform.rotation, gameObject.transform);
            }
        }
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
                //Instantiate(HandPile[i], gameObject.transform.position, gameObject.transform.rotation, gameObject.transform);
              //  HandPile[i].SetActive(true);
                Debug.Log(HandPile[i].activeInHierarchy);
            }
            else
            {
                Debug.Log("entered else case");
                Debug.Log(card_xseperation);
                x = (x + card_xseperation);
                z = z + 0.1f;
                new_pos = new Vector3(x, y, z);
                //Instantiate(HandPile[i], new_pos, gameObject.transform.rotation, gameObject.transform);
                //HandPile[i].SetActive(true);
               
                Debug.Log(HandPile[i].activeInHierarchy);
                //Debug.Log(hand[i - 1].transform.position.x);



            }
        }
    }

    public void focusOnCard(int instance)
    {
        //Debug.Log("Passed in int = " + numcrds);
        Debug.Log("focusOnCard function starting");
        for(int i = 0; i < HandPile.Count; i++)
        {
            Debug.Log(instance);
            Debug.Log(HandPile[i].GetInstanceID());
            if (instance == HandPile[i].GetInstanceID())
            {
                focus = i;
                Debug.Log("FoundFocus on " + i);
            }
            /*bool iFocus = HandPile[i].GetComponent<Crd>().checkFocus();
            Debug.Log("focus for"+ i + " = "+ iFocus)
            if (iFocus)
            {
                focus = i;
                Debug.Log("Current Focus is " + focus);
            }*/
        }
    }
    //public void RemoveFocus()

    
    //public void SearchFocus()
    public int getFocus()
    {
        
        if (focus != -1)
        {   
            Debug.Log("Removing focus from" + focus);
            HandPile[focus].GetComponent<Card>().RemoveFocus();
        }
        
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
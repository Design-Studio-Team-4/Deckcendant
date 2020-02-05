using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string cardName = "A Card";
    // * variable for the art here *
    public int efType = 0;
    public int efPower = 5;
    public int cost = 1;
    public GameObject CrdText;
    public enum CardState
    {
        isFocus,
        notFocus,
    }
    CardState state;
    void Start()
    {
        state = CardState.notFocus;
        CrdText.GetComponent<TextMesh>().text = cardName;
         

    }

    void Update()
    {

    }

    public string description()
    {
        switch (efType)
        {
            case 0:
                return "Deal " + efPower + " Damage";
            case 1:
                return "Gain " + efPower + " Block";
            case 2:
                return "Restore " + efPower + " HP";

        }
        return "Deal " + efPower + " Damage";

    }
    public void OnMouseDown()
    {  // int numcrds;
        //Removes focus from whatever card was focused on before
       // GameObject.FindGameObjectWithTag("PlayerHand").GetComponent<Hand>().RemoveFocus();// Seems to actually work to remove the bool;
        //Debug.Log("RemovedFocus");
        //sets the internal focus to true

        state = CardState.isFocus;
       // Debug.Log("Internal Focus Added" + isFocus);
        //numcrds = GameObject.FindGameObjectWithTag("PlayerHand").GetComponent<Hand>().HandPile.Count;
        GameObject.FindGameObjectWithTag("PlayerHand").GetComponent<Hand>().focusOnCard(this.GetInstanceID());

    }
    public void RemoveFocus()
    {
        state = CardState.notFocus;

    }
    
}
    
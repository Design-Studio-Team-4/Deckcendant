using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crd : MonoBehaviour
{
    public string cardName = "A Card";
    // * variable for the art here *
    public int efType = 0;
    public int efPower = 5;
    public int cost = 1;
    public GameObject CrdText;
    Vector3 startpos;
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
        startpos = gameObject.transform.position;

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
        
        if (state != CardState.isFocus)
        {

      
        GameObject.FindGameObjectWithTag("PlayerHand").GetComponent<Hand>().getFocus();// Seems to actually work to remove the bool;
       
        GameObject.FindGameObjectWithTag("PlayerHand").GetComponent<Hand>().focusOnCard(this.GetInstanceID());
        state = CardState.isFocus;
        Vector3 newpos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z - 0.2f);
        gameObject.transform.position = newpos;
        }
    }
    public void RemoveFocus()
    {
        state = CardState.notFocus;
        gameObject.transform.position = startpos;
    }
    public void changeStandardPos(Vector3 newpos)
    {
        startpos = newpos;

    }
}
    
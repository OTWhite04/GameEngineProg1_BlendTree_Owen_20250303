using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{

    

    //Enum for all the possible player interactons with objects.
    public enum InteractionType
    {
        Nothing,
        Pickup,
        Info,
        Dialogue
    }

    

    [Header("Type of Interactable")]
    public InteractionType interType;//Drop down for the enums above.

    
    

    //Interact method for pressing space to interact with an object.
    public void Interact(InteractionType state)
    {
        Debug.Log("Interacting with " + gameObject.name);
    
        //A switch state for all the interaction types.
        switch(state)
        {
            case InteractionType.Nothing:
            {
                    Nothing();
                    break;  
            }
            case InteractionType.Pickup:
            {
                    Pickup();
                    break;
            }
            case InteractionType.Info:
            {
                    Info();
                    break;
            }
            case InteractionType.Dialogue:
            {
                    Dialogue();
                    break;
            }

        }
    
    }

    public void Nothing()
    {
        Debug.Log("Interaction type not defined");
    }

    public void Pickup()
    {
        Debug.Log("Picking up object" + gameObject.name);
    }

    public void Info()
    {
        Debug.Log("Display info message on object" + gameObject.name);
    }

    public void Dialogue()
    {
        Debug.Log("Display dialogue" + gameObject.name);
    }
}

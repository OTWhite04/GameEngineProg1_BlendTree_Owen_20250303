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

    //TO DO:
    

    //Interact method for pressing space to interact with an object.
    public void Interact()
    {
        Debug.Log("Interacting with " + gameObject.name);
    
        //Check which enum is selected
        //Call method based on the enum InteractionType
        //"Method for each enum"
    
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

}

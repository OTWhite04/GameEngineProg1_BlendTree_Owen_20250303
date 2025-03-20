using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    //Reference for interactable objects, also sets it to null by default.
    public GameObject currentInterObj = null;


    //Method for staying within the trigger of interactable objects.
    private void OnTriggerStay2D(Collider2D other)
    {
        currentInterObj = other.gameObject;
    }

    //Method for leaving the trigger of the interactable object.
    private void OnTriggerExit2D(Collider2D collision)
    {
        currentInterObj = null;
    }
}

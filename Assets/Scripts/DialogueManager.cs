using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> dialogue;


    // Start is called before the first frame update
    void Start()
    {
        dialogue = new Queue<string>();

    }

    public void StartDialogue(string[] sentences)
    {
        foreach (string currentstring in sentences)
        {
            dialogue.Enqueue(currentstring);

        }

        
    }
    

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

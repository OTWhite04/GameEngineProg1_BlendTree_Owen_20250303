using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    
    //References for the ui objects.
    public GameObject mainMenu;
    public GameObject gamePlayUI;
    public GameObject pausedUI;
    public GameObject optionsUI;
    public GameObject dialogueUI;

    //Sets Main Menu to active.
    public void MainMenuUI()
    {
        Debug.Log("Enabling main menu UI");
        DisableAllUIPanels();
        mainMenu.SetActive(true);
        Cursor.visible = true;
    }
    //Sets gameplay UI to active.
    public void GameplayUI()
    {
        Debug.Log("Enabling gameplay UI");
        DisableAllUIPanels();
        gamePlayUI.SetActive(true);
        Cursor.visible = false;

    }
    //Sets Paused UI to active.
    public void PausedUI()
    {
        DisableAllUIPanels();
        pausedUI.SetActive(true);
        Cursor.visible = true;

    }

    //Sets OptionsUI to active.
    public void OptionsUI()
    {
        DisableAllUIPanels();
        optionsUI.SetActive(true);
        Cursor.visible = true;
    }


    public void DialogueUI()
    {
        DisableAllUIPanels();
        dialogueUI.SetActive(true);
        Cursor.visible = true;
    }

    //Disables all menus to start.
    public void DisableAllUIPanels()
    {
        mainMenu.SetActive(false);
        gamePlayUI.SetActive(false);
        pausedUI.SetActive(false);
        optionsUI.SetActive(false);
        dialogueUI.SetActive(false);
    }





}


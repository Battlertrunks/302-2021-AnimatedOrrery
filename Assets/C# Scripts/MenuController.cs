using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/// <summary>
/// THE MAIN MENU CONTROLLER/NAVIGATOR WHEN PLAYER INTERACTS WITH THE BUTTONS
/// </summary>
public class MenuController : MonoBehaviour
{
    // Getting the GameObject
    public GameObject aboutScreen;

    // Loads the game when the player presses Play button
    public void PlayTheGame()
    {
        SceneManager.LoadScene("Semi_Realistic_System");
    }

    // Sets active to the about screen true when the player clicks on About button
    public void AboutScreen()
    {
        aboutScreen.SetActive(true);
    }

    // Sets active to the about screen false when the player clicks on Back button
    public void BackButton()
    {
        aboutScreen.SetActive(false);
    }

    // Quits the game when the player clicks on the Quit button
    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    EventSystem theEventManager;
    public GameObject aboutScreen;

    void Start()
    {
        theEventManager = GetComponentInChildren<EventSystem>();
    }

    public void PlayTheGame()
    {
        SceneManager.LoadScene("Semi_Realistic_System");
    }

    public void AboutScreen()
    {
        aboutScreen.SetActive(true);
    }

    public void BackButton()
    {
        aboutScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

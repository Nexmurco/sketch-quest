using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    // public GameObject MainMenu;
    // public GameObject CreditsMenu;

    // Start is called before the first frame update
    void Start()
    {
        // MainMenuButton();
    }

    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
        // Quit Game
        Debug.Log("QUITTING GAME");
        Application.Quit();
    }
}

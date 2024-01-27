using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
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

    // public void CreditsButton()
    // {
    //     // Show Credits Menu
    //     MainMenu.SetActive(false);
    //     CreditsMenu.SetActive(true);
    // }

    // public void MainMenuButton()
    // {
    //     // Show Main Menu
    //     MainMenu.SetActive(true);
    //     CreditsMenu.SetActive(false);
    // }

    public void QuitButton()
    {
        // Quit Game
        Debug.Log("QUITTING GAME");
        Application.Quit();
    }
}

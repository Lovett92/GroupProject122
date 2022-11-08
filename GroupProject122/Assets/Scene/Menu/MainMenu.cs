// Cayden Lovett
// Oct/16/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Starts the game / goes to next scene
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    // Quit the game
    public void QuitGame()
    {
        //  Only need to show in editor that the button works
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

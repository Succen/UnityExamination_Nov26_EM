using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This component can be used to access methods for changing the scene, and quitting the game
// It can be used together with UnityEventOnTrigger, or UI-button-events, to decide when a scene should be changed or the game should be closed
public class SceneChangeHandler : MonoBehaviour
{
    public void ChangeScene()
    {
        // Load the scene named "NewScene"
        if (SceneManager.GetActiveScene().name == "Lore")
        {
            SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Single);
        }
        else if (SceneManager.GetActiveScene().name == "Level1")
            {
            SceneManager.LoadSceneAsync("Level2", LoadSceneMode.Single);
            }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

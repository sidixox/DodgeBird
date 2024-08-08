using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnEasy()
    {
        // Load the scene for Easy difficulty (e.g., scene index 1)
        SceneManager.LoadScene("Easy");
    }

    public void OnMedium()
    {
        // Load the scene for Medium difficulty (e.g., scene index 2)
        SceneManager.LoadScene("Medium");
    }

    public void OnHard()
    {
        // Load the scene for Hard difficulty (e.g., scene index 3)
        SceneManager.LoadScene("Hard");
    }

    public void OnQuit()
    {
        // Quit the application
        Application.Quit();
    }
}

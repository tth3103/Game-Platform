using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuControl : MonoBehaviour
{
    public AudioSource buttonPress;
    public void PlayGame()
    {
        buttonPress.Play();
        SceneManager.LoadScene("LevelSelectScene");
    }
    public void Credit()
    {
        buttonPress.Play();
        SceneManager.LoadScene("Credits");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuControl : MonoBehaviour
{
    public AudioSource buttonPress;
    public GameObject settingPanel;
    public void PlayGame()
    {
        buttonPress.Play();
        SceneManager.LoadScene("LevelSelectScene");
    }
    public void Settings()
    {
        buttonPress.Play();
        settingPanel.SetActive(true);
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

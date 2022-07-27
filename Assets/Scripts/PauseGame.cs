using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseGame : MonoBehaviour
{
    public bool isPaused = false;
    public AudioSource levelAudio;
    public GameObject pauseMenu;
    public AudioSource pauseSound;

    public string level;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (!isPaused)
            {
                pauseSound.Play();
                Time.timeScale = 0;
                isPaused = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                levelAudio.Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                levelAudio.UnPause();
                Cursor.visible=false;
                isPaused = false;
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }
        }
    }
    public void ResumeGame()
    {
        levelAudio.UnPause();
        Cursor.visible = false;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    public void RestartLevel()
    {
        levelAudio.UnPause();
        Cursor.visible = false;
        isPaused = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(level);
    }
    public void MainMenu()
    {
        levelAudio.UnPause();
        Cursor.visible = true;
        isPaused = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectLevel : MonoBehaviour
{
    public GameObject notificationBoard;
    public AudioSource clickSound;
    public AudioSource bgm;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        bgm.Play();
    }
    public void loadLevel_1()
    {
        SceneManager.LoadScene("Level001");
        bgm.Stop();
        clickSound.Play();
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_2()
    {
        SceneManager.LoadScene("Level002");
        bgm.Stop();
        clickSound.Play();
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_3()
    {
        SceneManager.LoadScene("Level003");
        bgm.Stop();
        clickSound.Play();
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_4()
    {
        SceneManager.LoadScene("Level004");
        bgm.Stop();
        clickSound.Play();
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_5()
    {
        SceneManager.LoadScene("Level005");
        bgm.Stop();
        clickSound.Play();
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_6()
    {
        bgm.Pause();
        clickSound.Play();
        notificationBoard.SetActive(true);
    }
    public void closeNotification()
    {
        clickSound.Play();
        bgm.UnPause();
        notificationBoard.SetActive(false);
    }
    public void returnToMenu()
    {
        bgm.Stop();
        clickSound.Play();
        SceneManager.LoadScene("MainMenu");
    } 
}

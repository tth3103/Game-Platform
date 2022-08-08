using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectLevel : MonoBehaviour
{
    public GameObject notificationBoard;
    public GameObject resetProgressNotif;

    public AudioSource clickSound;
    public AudioSource bgm;

    public Button[] lvlButtons;

    public GameObject[] lockSprites;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        bgm.Play();
        int levelAt = PlayerPrefs.GetInt("PlayerAt", 4);
        for(int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 4 > levelAt)
            {
                lvlButtons[i].interactable = false;
                lockSprites[i].SetActive(true);
            }
                
        }
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
        SceneManager.LoadScene("Level006");
        bgm.Stop();
        clickSound.Play();
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_7()
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
    public void ResetProgress()
    {
        clickSound.Play();
        resetProgressNotif.SetActive(true);
    }
    public void CancelButton()
    {
        clickSound.Play();
        resetProgressNotif.SetActive(false);
    }
    public void ResetButton()
    {
        PlayerPrefs.SetInt("PlayerAt", 4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void returnToMenu()
    {
        bgm.Stop();
        clickSound.Play();
        SceneManager.LoadScene("MainMenu");
    } 
}

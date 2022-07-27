using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectLevel : MonoBehaviour
{
    public GameObject notificationBoard;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void loadLevel_1()
    {
        SceneManager.LoadScene("Level001");
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_2()
    {
        SceneManager.LoadScene("Level002");
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_3()
    {
        SceneManager.LoadScene("Level003");
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_4()
    {
        SceneManager.LoadScene("Level004");
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_5()
    {
        SceneManager.LoadScene("Level005");
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void loadLevel_6()
    {
        notificationBoard.SetActive(true);
    }
    public void closeNotification()
    {
        notificationBoard.SetActive(false);
    }
    public void returnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    } 
}

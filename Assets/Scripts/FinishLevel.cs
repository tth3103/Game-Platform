using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FinishLevel : MonoBehaviour
{
    public GameObject player;
    public GameObject levelMusic;
    public GameObject levelComplete;
    public GameObject levelTimer;
    public GameObject scoreBoard;
    public GameObject title;
    public GameObject timeTaken;
    public GameObject score;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject fadeOut;

    public int nextSceneLoad;
    private int timeScore;
    public static bool isFinished;
    [HideInInspector]
    private static int finalScore;

    private void Start()
    {
        nextSceneLoad= SceneManager.GetActiveScene().buildIndex + 1;
    }
    private void Awake()
    {
        levelComplete.GetComponent<AudioSource>().enabled = false;
        isFinished = false;
    }
    void OnTriggerEnter()
    {
        GameObject.Destroy(player);
        Cursor.lockState=CursorLockMode.None;
        Cursor.visible = true;
        isFinished=true;
        //Calculate time score
        timeScore = Timer.timeLeft * 1/2;
        timeTaken.GetComponentInChildren<Text>().text = "Time left: " + Timer.timeLeft + "";

        //Calculate final score
        finalScore = GlobalScore.currentScore + timeScore;
        score.GetComponentInChildren<Text>().text = "Score: " + finalScore;

        //UI Control
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.GetComponent<AudioSource>().enabled = true;

        //Show result
        StartCoroutine(CaculateScore());
        
    }
    IEnumerator CaculateScore()
    {
        scoreBoard.SetActive(true);
        yield return new WaitForSeconds(0.75f);

        timeTaken.SetActive(true);
        yield return new WaitForSeconds(1.5f);

        score.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        if (finalScore >= GlobalScore.firstCap)
        {
            star1.SetActive(true);
            yield return new WaitForSeconds(0.75f);
            if (finalScore >= GlobalScore.secondCap)
            {
                star2.SetActive(true);
                yield return new WaitForSeconds(0.75f);
                if (finalScore >= GlobalScore.thirdCap)
                {

                    star3.SetActive(true);
                    yield return new WaitForSeconds(2f);
                }
            }
        }
        
    }
    public void PlayNextLevel()
    {
        SceneManager.LoadScene(nextSceneLoad);
        if (nextSceneLoad > PlayerPrefs.GetInt("PlayerAt"))
        {
            PlayerPrefs.SetInt("PlayerAt", nextSceneLoad);
        } 
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

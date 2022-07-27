using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    private bool isTakingTime=false;
    public int second=120;

    public static int timeLeft;
    public static int maxTime;

    private void Awake()
    {
        maxTime = second;
    }
    private void Update()
    {
        timeLeft = second;
        if (isTakingTime == false) 
        {
            StartCoroutine(SubtractSecond());
        }
    }
    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        second -= 1;
        timeDisplay.GetComponent<Text>().text = "" + second;
        yield return new WaitForSeconds(1);
        isTakingTime=false;
    }
}

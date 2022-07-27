using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalScore : MonoBehaviour
{
    public GameObject scoreBox;

    public static int currentScore;

    public int gemAmount;
    private int maxScore;

    [HideInInspector]
    public int internalScore;

    public static int firstCap;
    public static int secondCap;
    public static int thirdCap;

    private void Awake()
    {
        maxScore = gemAmount * 50;
        
        firstCap = maxScore-50*9 + Timer.maxTime*1/4;
        secondCap = maxScore-50*5 + Timer.maxTime*1/2;
        thirdCap = maxScore-50*3 + Timer.maxTime-2/3;
        currentScore = 0;
    }
    // Update is called once per frame
    void Update()
    {
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = "" + internalScore;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GemCounter : MonoBehaviour
{
    public GameObject gemCounter;
    public GameObject barrier;

    private int internalCounter;

    public static int currentCounter;
    private int maxAmount;
    private void Start()
    {
        maxAmount = GlobalScore.currentGemInLevel;
        currentCounter = 0;
    }
    // Update is called once per frame
    void Update()
    {
        internalCounter = currentCounter;
        gemCounter.GetComponentInChildren<Text>().text = "collected: "+internalCounter+"/"+maxAmount;
        if (internalCounter == maxAmount)
        {
            StartCoroutine(TurnOffBarrier());
        }
    }
    IEnumerator TurnOffBarrier()
    {
        barrier.SetActive(false);
        yield return null;
    }
}

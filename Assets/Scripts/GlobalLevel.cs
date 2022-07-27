using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GlobalLevel : MonoBehaviour
{
    private int currentLevel;
    public GameObject levelDisplay;
    void Awake()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex-3;
    }

    void Update()
    {
        levelDisplay.GetComponent<Text>().text = "Level " + currentLevel;
    }
}

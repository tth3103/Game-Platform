using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashToMenu : MonoBehaviour
{
    public GameObject logo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RunSplash());
    }
    IEnumerator RunSplash()
    {
        yield return new WaitForSeconds(0.5f);
        logo.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene("MainMenu");
    }
}

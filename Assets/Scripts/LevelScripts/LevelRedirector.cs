using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelRedirector : MonoBehaviour
{
    public string sceneName;
    public GameObject fadeIn;
    void Start()
    {
       RedirectToLevel.scene = sceneName;
        StartCoroutine(FadeInOff());
    }
    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathControl : MonoBehaviour
{
    public GameObject DeathSign;
    public GameObject levelAudio;
    public GameObject fadeScene;
    private void OnTriggerEnter()
    {
        StartCoroutine(YouFell());
    }
    IEnumerator YouFell()
    {
        levelAudio.SetActive(false);
        DeathSign.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeScene.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("RedirectLevel");
    }
}

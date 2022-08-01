using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    public AudioSource bgm;
    private void Start()
    {
        bgm.Play();
        StartCoroutine(RollCredit());   
    }
    public GameObject credit;
    IEnumerator RollCredit()
    {
        yield return new WaitForSeconds(0.5f);
        credit.SetActive(true);
        yield return new WaitForSeconds(15f);
        SceneManager.LoadScene("MainMenu");
    }
}

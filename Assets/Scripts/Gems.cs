using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class  Gems : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;
    private void OnTriggerEnter()
    {
        GlobalScore.currentScore += 50;
        collectSound.Play();
        Destroy(gameObject);
    }
}

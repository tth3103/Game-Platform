using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class DebuffItems : MonoBehaviour
{
    public GameObject PlayerCharacter;
    public GameObject Effect;
    private const float playerMoveSpeed = 10f;
    private float currentMoveSpeed;
    public float timer;
    private bool alreadyTriggered;

    private void Awake()
    {
        alreadyTriggered = false;
    }

    private void OnTriggerEnter()
    {
        if (!alreadyTriggered)
        {
            StartCoroutine(SlowEffect());
            alreadyTriggered = true;
        }
        else return;
    }
    private IEnumerator SlowEffect()
    {
        gameObject.GetComponent<MeshRenderer>().enabled=false;
        //apply debuff on player move speed
        currentMoveSpeed = 10-10*0.8f;
        PlayerCharacter.GetComponent<ThirdPersonController>().MoveSpeed = currentMoveSpeed;
        Effect.SetActive(true);
        yield return new WaitForSeconds(timer);
        //return player move speed
        PlayerCharacter.GetComponent<ThirdPersonController>().MoveSpeed = playerMoveSpeed;
        Effect.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }
}

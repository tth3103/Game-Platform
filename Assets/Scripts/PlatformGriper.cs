using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGriper : MonoBehaviour
{
    public GameObject movingPlatform;
    public int animIndex=0;
    private Animator anim;
    public GameObject player;
    private void Start()
    {
        anim=movingPlatform.GetComponent<Animator>();
        anim.SetInteger("LevelAnimation", animIndex);
    }
    private void OnTriggerEnter()
    {
        player.transform.parent = movingPlatform.transform;
    }
    private void OnTriggerExit()
    {
        player.transform.parent = null;
    }
}

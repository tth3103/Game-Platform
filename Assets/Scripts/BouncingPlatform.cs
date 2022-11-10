using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class BouncingPlatform : MonoBehaviour
{
    public GameObject player;
    private float originalForce;
    [SerializeField]
    private float jumpForce=10f;
    private void OnTriggerEnter()
    {
         originalForce= player.GetComponent<ThirdPersonController>().JumpHeight;
         player.GetComponent<ThirdPersonController>().JumpHeight =jumpForce;
    }
    private void OnTriggerExit(Collider other)
    {        
         player.GetComponent<ThirdPersonController>().JumpHeight = originalForce;
    }
}

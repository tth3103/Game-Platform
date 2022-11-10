using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloater : MonoBehaviour
{
    [SerializeField]
    public float speed=1f;
    private Animator anim;
    public CharacterController player;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed",speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            float bounce = 1.5f;
            player.Move(Vector3.forward.normalized * bounce);
        }
    }
}

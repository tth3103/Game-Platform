using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWaypoint : MonoBehaviour
{
    [SerializeField]
    public GameObject Player;
    public GameObject targetPoint;

    private void OnTriggerEnter()
    {
        Player.transform.position = targetPoint.transform.position;
    }
}

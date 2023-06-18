using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            Debug.Log("hit an obstacle");
            playerMovement.enabled = false;
        }
    }
}

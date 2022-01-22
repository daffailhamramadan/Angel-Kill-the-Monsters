using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Camera playerCamera;

    private void Awake()
    {
        playerCamera = Camera.main;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("DoorCheck"))
        {
            playerCamera.transform.position = new Vector3(collision.transform.parent.transform.position.x, collision.transform.parent.transform.position.y, playerCamera.transform.position.z) ;
        }
    }
}

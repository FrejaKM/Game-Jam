using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
 // Reference to the player GameObject.
 public GameObject player;

 // The distance between the camera and the player.
 private Vector3 offset;

 // Start is called before the first frame update.
 void Start()
    {
 // Calculate the initial offset between the camera's position and the player's position.
        offset = transform.position - player.transform.position; 
    }

 // LateUpdate is called once per frame after all Update functions have been completed.
 void LateUpdate()
{
    // Check if the player still exists before trying to access its transform
    if (player != null)
    {
        // Your existing camera follow code here
        // For example:
        transform.position = player.transform.position + offset;
    }
}
}
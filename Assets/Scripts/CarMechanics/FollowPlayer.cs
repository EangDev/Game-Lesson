using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -8);

    // Update is called once per frame
    void LateUpdate()
    {
        // assign the camera’s position to the player’s position plus an new Vector3 for offset
        transform.position = player.transform.position + /*new Vector3(0, 5, -8)*/ offset;
    }
}

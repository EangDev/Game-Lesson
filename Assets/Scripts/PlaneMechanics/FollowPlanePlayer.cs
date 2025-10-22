using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlanePlayer : MonoBehaviour
{
    public GameObject playerPlane;

    private Vector3 offset = new Vector3(30, 0, 10);

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPlane.transform.position + offset;
    }
}

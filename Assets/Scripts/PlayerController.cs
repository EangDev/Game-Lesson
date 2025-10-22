using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transform.Translate(/*0, 0, 1*/ Vector3.forward * Time.deltaTime * speed);
    }
}

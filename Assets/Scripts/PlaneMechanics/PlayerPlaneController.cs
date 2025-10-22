using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlaneController : MonoBehaviour
{
    public float speed = 20f;

    private float verticalInput;
    private float rotateTurnSpeed = 45f;    


    void LateUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Rotate(Vector3.left, rotateTurnSpeed * verticalInput * Time.deltaTime);
    }
}

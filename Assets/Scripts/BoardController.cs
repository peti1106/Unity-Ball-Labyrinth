using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [Range(0, 100)] [SerializeField] public float tiltSpeed = 30f;

    private float horizontalTilt = 0f;
    private float verticalTilt = 0f;

    // Update is called multiple times per frame
    void FixedUpdate()
    {
        horizontalTilt = Input.GetAxisRaw("Horizontal") * tiltSpeed;
        verticalTilt = Input.GetAxisRaw("Vertical") * tiltSpeed;
        Tilt(horizontalTilt * Time.fixedDeltaTime, verticalTilt * Time.fixedDeltaTime);
    }

    void Tilt(float horizontalTilt, float verticalTilt) 
    {
        transform.Rotate(horizontalTilt, 0f, verticalTilt, Space.Self);
    }
}

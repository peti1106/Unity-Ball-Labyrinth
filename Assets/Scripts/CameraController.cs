using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Range(0, 100)] [SerializeField] public float rotateSpeed = 30f;

    public Transform centerPivot;

    private Vector3 pivotPosition;

    // Start is called before the first frame update
    void Start()
    {
        pivotPosition = centerPivot.transform.position;
        transform.LookAt(pivotPosition);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Mouse X") * rotateSpeed;
        transform.RotateAround(pivotPosition, new Vector3(0.0f, 1.0f, 0.0f), horizontalMove * Time.fixedDeltaTime * rotateSpeed);
    }
}

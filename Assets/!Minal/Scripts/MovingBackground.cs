using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    [SerializeField] private Vector2 backgroundMoveSpeed;    
    private Transform cameraTransform;    
    private Vector3 lastCameraPosition;
    //private Vector3 startPos;
    //private float repeatWidth;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;               
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position += new Vector3(deltaMovement.x * backgroundMoveSpeed.x, deltaMovement.y * backgroundMoveSpeed.y);
        lastCameraPosition = cameraTransform.position;       
    }   
}

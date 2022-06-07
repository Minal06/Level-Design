using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinyMovement : MonoBehaviour
{
    public AnimationCurve animCurve;
    [SerializeField] float spinSpeed;
    private Vector3 startingPos;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, startingPos.y + animCurve.Evaluate((Time.time % animCurve.length)), transform.position.z);
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}

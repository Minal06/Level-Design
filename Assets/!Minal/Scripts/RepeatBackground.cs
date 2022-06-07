using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    [SerializeField] Transform cBackground;
   

    void Update()
    {
        if(transform.position.x >= cBackground.position.x+ 118f)
        {
            cBackground.position = new Vector3 (transform.position.x + 118f, transform.position.y, transform.position.z+55f);
        }
        else if (transform.position.x <= cBackground.position.x - 118f)
        {
            cBackground.position = new Vector3(cBackground.position.x - 118f, transform.position.y, transform.position.z+55f);
        }
    }
}

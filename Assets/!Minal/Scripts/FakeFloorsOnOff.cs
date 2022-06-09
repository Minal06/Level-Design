using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeFloorsOnOff : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnControlPressed += ChangeRed;

        EventManager.OnControlPressed += TurnColor;
    }

    private void OnDisable()
    {
        EventManager.OnControlPressed -= ChangeRed;

        EventManager.OnControlPressed -= TurnColor;
    }

    bool isRed = false;

    void ChangeRed()
    {
        isRed = !isRed;
        //Debug.Log(isRed);
    }

    void TurnColor()
    {
        if (isRed == true)
        {            
            GetComponent<MeshCollider>().enabled = true;
            GetComponent<Renderer>().enabled = true;
        }
        else if (isRed == false)
        {           
            GetComponent<MeshCollider>().enabled = false;
            GetComponent<Renderer>().enabled = false;
        }
    }
}

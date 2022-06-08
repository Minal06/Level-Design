using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnObstaclesOnOff : MonoBehaviour
{
    // Start is called before the first frame update
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
            GetComponent<BoxCollider>().enabled = true;
            GetComponentInChildren<Renderer>().enabled = false;
        }
        else if (isRed == false)
        {            
           GetComponent<BoxCollider>().enabled = false;
           GetComponentInChildren<Renderer>().enabled = true;
        }
    }
}

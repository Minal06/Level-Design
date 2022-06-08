using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptColorChange : MonoBehaviour
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
        Debug.Log(isRed);
    }

    void TurnColor()
    {
        if (isRed == true)
        {
            Color col = new Color(Random.value, Random.value, Random.value, 0.5f);
            GetComponent<Renderer>().material.color = col;
        }   
        else if (isRed == false)
        {
            Color col = new Color(Random.value, Random.value, Random.value);
            GetComponent<Renderer>().material.color = col;
        }
    }
    void TurnBack()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}


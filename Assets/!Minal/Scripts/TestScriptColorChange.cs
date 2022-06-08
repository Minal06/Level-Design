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

    [SerializeField] GameObject g;
    void TurnColor()
    {
        if (isRed == true)
        {
            Color _col = gameObject.GetComponent<Renderer>().material.color;
            _col.a = 1f;
            gameObject.GetComponent<MeshRenderer>().material.color = _col;
            GetComponent<MeshCollider>().enabled = true;
        }   
        else if (isRed == false)
        {
            Color _col = gameObject.GetComponent<Renderer>().material.color;
            _col.a = 0.3f;
            gameObject.GetComponent<MeshRenderer>().material.color = _col;          
            GetComponent<MeshCollider>().enabled = false;
        }
    }   
}
//(Random.value, Random.value, Random.value);

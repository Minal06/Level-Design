using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlatformChange : MonoBehaviour
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

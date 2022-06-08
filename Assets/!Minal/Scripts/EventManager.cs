using System;
using UnityEngine;


public class EventManager : MonoBehaviour
{
    public delegate void RedEnvironment();
    public static event RedEnvironment OnControlPressed;   

   /* private void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width/2-50,5,100,30), "click"))
        {
            if (OnClicked != null)
                OnClicked();
        }
    }*/
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            if (OnControlPressed != null)
            {
                OnControlPressed();
            }             
            
        }
    }
}

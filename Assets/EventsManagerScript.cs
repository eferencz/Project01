using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventsManagerScript : MonoBehaviour
{
    public Text textHeader;

    public void MessageConsole()
    {
        Debug.Log("You pressed the button! " + Time.time + " seconds");
        textHeader.text = "Nice job! You're so talented!";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    // public UnityEvent unlock;
    public GameObject rightDoor;
    public GameObject leftDoor;
    public string code = "GPB";
    string currCode;

    public Text codeDisplay;

    void KeyEntry(string key)
    {
        currCode += key;
        if(currCode == code)
        {
            codeDisplay.text = "Code: " + currCode;
            //unlock.Invoke();
            rightDoor.transform.Rotate(0, -90, 0);
            leftDoor.transform.Rotate(0, 90, 0);
        }
        else if(currCode.Length == code.Length)
        {
            currCode = "";
            codeDisplay.text = "Code: " + currCode;
        }
        else
        {
            codeDisplay.text = "Code: " + currCode;
        }
    }
}

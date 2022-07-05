using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterCode : MonoBehaviour
{
    public GameObject cube_1, cube_2, cube_3, cube_4, cube_5, 
                        cube_6, cube_7, cube_8, cube_9, cube_0, 
                        cube_E, cube_D, wall;
    public Text code_text, billboard_text;
    public GameObject hand, billboard;

    GameObject temp = null;
    public bool holding = false;
    public bool entered = false;

    // Start is called before the first frame update
    void Start()
    {
        code_text.text = "CODE: ";
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(entered);

        if (hand.transform.childCount == 2)
        {
            GameObject cube = hand.transform.GetChild(1).gameObject;
            if (entered == false)
            {
                if (cube.transform.tag == "cubeNum")
                {
                    entered = true;
                    temp = cube;
                    code_text.text += cube.transform.GetComponentInChildren<Text>().text;
                } 
            }
            
        } else
        {
            entered = false;
        }

        if (cube_E.transform.GetComponent<OVRGrabbable>().isGrabbed) 
        { 
            if (code_text.text == "CODE: 14100495501")
            {
                wall.SetActive(false);
                code_text.text = "Correct!\n\nCONGRATULATIONS! YOU WON!";
                billboard_text.text = "THANKS FOR PLAYING!";
                billboard.SetActive(true);
                
            } 
        } else if (cube_D.transform.GetComponent<OVRGrabbable>().isGrabbed)
        {
            code_text.text = "Code: ";
        }
    }
}

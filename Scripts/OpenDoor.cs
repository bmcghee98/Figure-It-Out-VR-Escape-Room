using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject red, blue, green, pink, door;

    public bool unlock = false;
    public bool redG = false;
    public bool blueG = false;
    public bool greenG = false;
    public bool pinkG = false;
    int touched;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == red.gameObject.name) { redG = true; }
        if (other.gameObject.name == blue.gameObject.name) { blueG = true;  }
        if (other.gameObject.name == green.gameObject.name) { greenG = true; }
        if (other.gameObject.name == pink.gameObject.name) { pinkG = true; }
    }

    // Update is called once per frame
    void Update()
    {
        if (unlock == false)
        {
            if (greenG == true)
            {
                if (blueG == true)
                {
                    door.SetActive(false);
                    unlock = true;
                }
            }
        } else { touched = 0; }
    }
}

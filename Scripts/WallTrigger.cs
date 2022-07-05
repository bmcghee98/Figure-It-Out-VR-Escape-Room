using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallTrigger : MonoBehaviour
{
    public GameObject slideWall;
    public Text timeout_text;
    public ClassRank c;

    public bool moveDoor = false;
    public float timer = 0;
    public int seconds = 0;
    public int temp = 0;
    public bool inTimeout = false;
    public bool done = false;

    void OnTriggerEnter(Collider other)
    {
        if (inTimeout == false)
        {
            if (other.tag == "Player")
            {
                if (c.done1 == true && c.done2 == true)
                {
                    moveDoor = true;
                    inTimeout = true;
                    temp = seconds;
                    timeout_text.text = "WAIT";
                }
                
            }
        }
       
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        slideWall.SetActive(true);
        c = GameObject.FindGameObjectWithTag("VRTag4").GetComponent<ClassRank>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
      
        if (done == false)
        {
            if (moveDoor == true)
            {
                Debug.Log(seconds - temp);

                if ((seconds - temp) >= 5)
                {
                    slideWall.SetActive(false);
                    moveDoor = false;

                    timeout_text.text = "I HOPE YOU LEARNED YOUR LESSON.\nNOW GO BACK TO CLASS >:(";
                    done = true;
                }

            }
        }
        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassRank : MonoBehaviour
{
    public Text ranking_text;
    public Text computer_text;
    public int score = 380;
    public int jessScore = 0;
    public int tedScore = 20;
    public static int b = 0;
    string bonus = "BONUS: ";
    public ReturnBook r;
    public PickupTrash t;
    public WallTrigger w;
    public bool done1 = false;
    public bool done2 = false;
    public bool done3 = false;

    string jess, ted;
    // Start is called before the first frame update
    private void Start()
    {
        r = GameObject.FindGameObjectWithTag("VRTag").GetComponent<ReturnBook>();
        t = GameObject.FindGameObjectWithTag("VRTag2").GetComponent<PickupTrash>();
        w = GameObject.FindGameObjectWithTag("VRTag3").GetComponent<WallTrigger>();

        jess = "Jessica - " + jessScore;
        ted = "Ted - " + tedScore;
        ranking_text.text = "CLASS RANKINGS:\n\nAmber - 100\nSally - 97\nJohn - 86\nRafael - 77\n" + ted + "\n" + jess + "\n\n" + bonus + "\n\nOVERALL: " + score + "\n\nIF YOUR SCORE IS BELOW 70\n\nSEE ME AT MY DESK";
    }

    // Update is called once per frame
    void Update()
    {
        if (r.bookReturn == true)
        {
            if (done1 == false)
            {
                jessScore += 82;
                score += jessScore;
                jess = "Jessica - " + jessScore;
                ranking_text.text = "CLASS RANKINGS:\n\nAmber - 100\nSally - 97\nJohn - 86\nRafael - 77\n" + jess + "\nTed - 20\n\n" + bonus + "\n\nOVERALL: " + score + "\n\nIF YOUR SCORE IS BELOW 70\n\nSEE ME AT MY DESK";
                computer_text.text = "GO TO TIMEOUT";
                done1 = true;
            }
        }

        if (t.allTrash == true)
        {
            if (done2 == false)
            {
                b += 30;
                bonus = "BONUS: " + b;
                score += b;

                if (done1 == true)
                {
                    ranking_text.text = "CLASS RANKINGS:\n\nAmber - 100\nSally - 97\nJohn - 86\nRafael - 77\n" + jess + "\n" + ted + "\n\n" + bonus + "\n\nOVERALL: " + score + "\n\nIF YOUR SCORE IS BELOW 70\n\nSEE ME AT MY DESK";
                }
                else
                {
                    ranking_text.text = "CLASS RANKINGS:\n\nAmber - 100\nSally - 97\nJohn - 86\nRafael - 77\n" + ted + "\n" + jess + "\n\n" + bonus + "\n\nOVERALL: " + score + "\n\nIF YOUR SCORE IS BELOW 70\n\nSEE ME AT MY DESK";
                }

                t.allTrash = false;
                done2 = true;
            }
        }

        if (w.done == true)
        {
            if (done3 == false)
            {
                tedScore += 58;
                score += 58;
                ted = "Ted - " + tedScore;

                if (done1 == true)
                {
                    ranking_text.text = "CLASS RANKINGS:\n\nAmber - 100\nSally - 97\nJohn - 86\nRafael - 77\n" + jess + "\n" + ted + "\n\n" + bonus + "\n\nOVERALL: " + score + "\n\nIF YOUR SCORE IS BELOW 70\n\nSEE ME AT MY DESK";
                }
                else
                {
                    ranking_text.text = "CLASS RANKINGS:\n\nAmber - 100\nSally - 97\nJohn - 86\nRafael - 77\n" + ted + "\n" + jess + "\n\n" + bonus + "\n\nOVERALL: " + score + "\n\nIF YOUR SCORE IS BELOW 70\n\nSEE ME AT MY DESK";
                }
                done3 = true;
            }
        }


    }
}

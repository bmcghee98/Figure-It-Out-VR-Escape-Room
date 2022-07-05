using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrash : MonoBehaviour
{
    public GameObject cup1, cup2, toiletpaper;

    public bool cup1R = false;
    public bool cup2R = false;
    public bool toiletR = false;
    public bool allTrash = false;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == cup1.gameObject.name)
        {
            cup1R = true;
        }

        if (other.gameObject.name == cup2.gameObject.name)
        {
            cup2R = true;
        }

        if (other.gameObject.name == toiletpaper.gameObject.name)
        {
            toiletR = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (allTrash == false) 
        {
            if (cup1R && cup2R && toiletR)
            {
                allTrash = true;
            }
        }
        
    }
}

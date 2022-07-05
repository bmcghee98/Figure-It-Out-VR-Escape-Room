using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookTrigger : MonoBehaviour
{
    public GameObject JessicaNote;

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Book")
        {
            JessicaNote.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        JessicaNote.SetActive(false);
    }
}

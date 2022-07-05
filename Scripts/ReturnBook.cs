using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnBook : MonoBehaviour
{
    public GameObject jessica_book;
    public GameObject jessica_sheet;

    public bool bookReturn = false;

    private void OnTriggerEnter(Collider other)
    {
        if (bookReturn == false)
        {
            if (other.gameObject.name == jessica_book.gameObject.name)
            {
                jessica_sheet.SetActive(true);
                bookReturn = true;
            }
        }

    }
}

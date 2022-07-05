using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BillBoardTrigger : MonoBehaviour
{
    public GameObject UIObject;
    void OnTriggerEnter(Collider other)
    {
        UIObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(false);
    }

    void Start()
    {
        UIObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
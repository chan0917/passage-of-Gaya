using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P_UIController : MonoBehaviour
{
    public Text text;
    public bool IsCollision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)

    {
        IsCollision = true;
    }

    private void OnTriggerExit(Collider other)

    {
        IsCollision = false;

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P_UIController : MonoBehaviour
{
    public Text I_key;
    public GameObject text;
    public bool IsCollision;
    public GameObject obj;

    public Animator animator;


    public GameObject P_obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCollision == true && obj.name == "D_Collider")
        {
            if (animator.GetBool("IsOpen") == false)
                I_key.text = "[E] 문열기";
            else
                I_key.text = "[E] 문닫기";
        }
        else
            I_key.text = "[E] 유물조사";
    }

    private void OnTriggerStay(Collider other)

    {
        text.SetActive(true);
        IsCollision = true;
        obj = other.gameObject;
        P_obj = obj.transform.parent.gameObject;
        animator = P_obj.GetComponent<Animator>();
    }

    private void OnTriggerExit(Collider other)

    {
        text.SetActive(false);
        IsCollision = false;

    }
}

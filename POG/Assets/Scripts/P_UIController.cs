using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class P_UIController : MonoBehaviour // �÷��̾� 
{
    public Text I_key;
    public GameObject text;
    public bool IsCollision;
    public GameObject obj;
    public bool AAA;

    public Animator animator;

    public GameObject P_obj;

    public O_UIController ouiController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCollision == true && obj.name == "D_Collider")
        {
            
                

            if (animator.GetBool("IsOpen") == false && AAA == false)
                I_key.text = "[E] ������";
            else
                I_key.text = "[E] ���ݱ�";
        }
        else if (obj.layer == 8)
            I_key.text = "[E] ��������";

        if (ouiController.IsRearn == true)
        {
            I_key.text = "������";
        }
        if (ouiController.IsOpen == true)
        {
            I_key.text = "";

        }
    }

    private void OnTriggerStay(Collider other)

    {
        
        text.SetActive(true);
        IsCollision = true;
        obj = other.gameObject;
        P_obj = obj.transform.parent.gameObject;
        if (obj.layer == 8) return;
        animator = P_obj.GetComponent<Animator>();
    }

    private void OnTriggerExit(Collider other)

    {
        text.SetActive(false);
        IsCollision = false;

    }
}

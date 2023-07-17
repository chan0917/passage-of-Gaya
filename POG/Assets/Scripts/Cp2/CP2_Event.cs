using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CP2_Event : MonoBehaviour
{
    public float timer;
    public bool AA = false;
    public int INTTIME;
    public bool LASTTP;
    public bool FINAL;
    public AudioSource laugh;

    public P_UIController uicontroller;

    [Header("Event1")]
    [SerializeField] AudioSource e1;
    [SerializeField] GameObject e1_obj;

    [Header("Event2")]
    public GameObject e2_trigger;
    [SerializeField] Vector3 OriginPos = Vector3.zero;
    [SerializeField] Vector3 MovePos = new Vector3(0f, 0f, 0f);

    [Header("Event2-2")]
    public GameObject e2_ghost;
    [SerializeField] Vector3 g_OriginPos = Vector3.zero;
    [SerializeField] Vector3 g_MovePos = new Vector3(0f, 0f, 0f);
    public Animator G_anim;

    [Header("Event3")]
    [SerializeField] GameObject F1;
    [SerializeField] GameObject F2;
    [SerializeField] GameObject F3;
    [SerializeField] GameObject F4;
    [SerializeField] GameObject F5;
    [SerializeField] GameObject F6;
    [SerializeField] GameObject F7;
    [SerializeField] GameObject F8;
    [SerializeField] GameObject F9;
    [SerializeField] GameObject F10;
    [SerializeField] GameObject F11;
    [SerializeField] GameObject F12;
    [SerializeField] GameObject F13;
    [SerializeField] GameObject F14;
    [SerializeField] GameObject F15;
    [SerializeField] AudioSource e3;
    [SerializeField] AudioSource e4;
    [SerializeField] AudioSource ee;
    [SerializeField] GameObject FF;
    [SerializeField] Light LLL;
    [SerializeField] Light L1;
    [SerializeField] Light L2;
    [SerializeField] Light L3;
    [SerializeField] GameObject L4;
    [SerializeField] GameObject L5;
    [SerializeField] GameObject L6;


    // Start is called before the first frame update
    void Start()
    {
        OriginPos = e2_trigger.transform.position;
        MovePos = OriginPos + new Vector3(0f, 20f, 0f);
        e2_trigger.transform.position = MovePos;

        g_OriginPos = e2_ghost.transform.position;
        g_MovePos = g_OriginPos + new Vector3(0f, 20f, 0f);
        e2_ghost.transform.position = g_MovePos;
    }

    // Update is called once per frame
    void Update()
    {
        if (uicontroller.IsDie == true)
        {
            laugh.Play();
            StartCoroutine(E2_Ready());


        }



        if (uicontroller.C2_1L == true) //귀신 웃음소리 시작
        {
            Debug.Log("Event1");
            e1_obj.SetActive(false);
            
            uicontroller.C2_2Ready = true;

        }
        
        if (uicontroller.C2_2Ready == true) //2번 트리거 준비완료
        {
           
            e2_trigger.transform.position = OriginPos;
            Debug.Log("Event2-1");
        }
        
        if (uicontroller.C2_2Run == true)//귀신 달리기
        {
            e2_trigger.transform.position = MovePos;
            e2_ghost.transform.position = g_OriginPos;
            Debug.Log("Event2-2");
            if (Input.GetKey(KeyCode.F))
            {
                StartCoroutine(E2_Run());
                
                AA = true;
            }//랜턴끄기 넣어주기

            if (AA == true)
            {
                

                timer += Time.deltaTime;
            }
                
            INTTIME = Convert.ToInt32(timer);
        }

        //if (Input.GetKeyDown(KeyCode.K))
        if (INTTIME == 20 || Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(uicontroller.BBB());
            INTTIME += 1;
            StartCoroutine(E1());
        }

        

    }

    public IEnumerator E1()
    {
        yield return new WaitForSeconds(.15f);
        F1.SetActive(true);
        e3.Play();
        
        yield return new WaitForSeconds(.15f);
        F2.SetActive(true);
        e4.Play();
        
        yield return new WaitForSeconds(.15f);
        F3.SetActive(true);
        e3.Play();

        yield return new WaitForSeconds(.15f);
        F4.SetActive(true);
        e4.Play();

        yield return new WaitForSeconds(.15f);
        F5.SetActive(true);
        e3.Play();

        yield return new WaitForSeconds(.15f);
        F6.SetActive(true);
        e4.Play();

        yield return new WaitForSeconds(.15f);
        F7.SetActive(true);
        e3.Play();

        yield return new WaitForSeconds(.15f);
        F8.SetActive(true);
        e4.Play();

        yield return new WaitForSeconds(.15f);
        F9.SetActive(true);
        e3.Play();

        yield return new WaitForSeconds(.15f);
        F10.SetActive(true);
        e4.Play();

        yield return new WaitForSeconds(.15f);
        F11.SetActive(true);
        e3.Play();

        yield return new WaitForSeconds(.15f);
        F12.SetActive(true);
        e4.Play();

        yield return new WaitForSeconds(.15f);
        F13.SetActive(true);
        e4.Play();

        yield return new WaitForSeconds(.15f);
        F14.SetActive(true);
        e3.Play();

        yield return new WaitForSeconds(.15f);
        F15.SetActive(true);
        e4.Play();

        yield return new WaitForSeconds(1f);
        ee.Play();
        FF.SetActive(false);
        LLL.intensity = 0.8f;
        FINAL = true;


        






    }

    public IEnumerator E2_Ready()
    {
        Debug.Log("qkedma");
        yield return new WaitForSeconds(3f);
        laugh.Play();
        L4.SetActive(true);
        L6.SetActive(false);
        //이제 머리나옴
        yield return new WaitForSeconds(5f);
        LASTTP = true; //마지막 시작검
    }

    public IEnumerator E2_Run()
    {
        yield return new WaitForSeconds(.1f);

        G_anim.Play("Ghost", 0, 0f);
        yield return new WaitForSeconds(1f);
        
        e2_ghost.SetActive(false);
        yield return new WaitForSeconds(.1f);
        L5.SetActive(false);



    }
}

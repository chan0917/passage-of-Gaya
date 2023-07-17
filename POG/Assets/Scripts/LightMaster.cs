using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class LightMaster : MonoBehaviour //Ä«¸Þ¶ó
{
    public Light llight;
    public Light Llight;
    public Light D_light;
    public Animator animator;
    public GameObject Holder;
    public bool IsOn = true;

    public O_UIController o_UIController;
    public P_AnimeController p_AnimeController;
    public AudioSource hand;
    public AudioSource bgm;
    public AudioSource low;

    Vector3 pos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(o_UIController.O_Second);
        Debug.Log(p_AnimeController.A_DoorOpen);
        if (o_UIController.O_Second == true && p_AnimeController.A_DoorOpen == false)
        {
            StartCoroutine(Blink());

        }
        else
        {
            D_light.intensity = 0;
            
        }
            




        //Debugs
        if (Input.GetKeyDown(KeyCode.F))
        {
            L_OnOff();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(TurnOn());
        }
    }
    
    

    public IEnumerator TurnOn()
    {
        yield return new WaitForSeconds(1f);

        pos = Holder.transform.position + new Vector3(0f, 1f, 0f);
        Holder.transform.position = pos;
        animator.Play("HHand",0 , 0f); 
        IsOn = true;
        llight.intensity = 0.4f;
        Llight.intensity = 0.4f;
        hand.Play();
        yield return new WaitForSeconds(.7f);
        for(int i = 0; i < 1; i++)
        {
            
            llight.intensity = 0;
            Llight.intensity = 0;
            yield return new WaitForSeconds(.35f);
            hand.Play();
            llight.intensity = 0.4f;
            Llight.intensity = 0.4f;
            yield return new WaitForSeconds(.1f);
        }

    }

    public IEnumerator Blink()
    {
        D_light.intensity = 0;
        D_light.intensity = 0;
        yield return new WaitForSeconds(.5f);
        D_light.intensity = 0.5f;
        D_light.intensity = 0.5f;
        yield return new WaitForSeconds(.5f);
        
        

    }
    public void L_OnOff()
    {
        if (IsOn == true)
        {
            llight.intensity = 0;
            Llight.intensity = 0;
            IsOn = false;
        }
        else if (IsOn == false)
        {
            llight.intensity = 0.4f;
            Llight.intensity = 0.4f;
            IsOn = true;
        }
    }
}

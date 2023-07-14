using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class LightMaster : MonoBehaviour
{
    public Light llight;
    public Light Llight;
    public Animator animator;
    public GameObject img;
    public GameObject Holder;
    public bool IsOn = true;

    Vector3 pos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        //Debugs
        if (Input.GetKeyDown(KeyCode.F))
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
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(TurnOn());
        }
    }
    
    public void Blink()
    {
        
    }

    public IEnumerator TurnOn()
    {
        pos = Holder.transform.position + new Vector3(0f, 1f, 0f);
        Holder.transform.position = pos;
        animator.Play("Hand",0 , 0f); 
        IsOn = true;
        llight.intensity = 0.4f;
        Llight.intensity = 0.4f;
        yield return new WaitForSeconds(.7f);
        for(int i = 0; i < 1; i++)
        {
            //img.SetActive(true);
            llight.intensity = 0;
            Llight.intensity = 0;
            yield return new WaitForSeconds(.35f);
            img.SetActive(false);
            llight.intensity = 0.4f;
            Llight.intensity = 0.4f;
            yield return new WaitForSeconds(.1f);
        }
        
    }
}

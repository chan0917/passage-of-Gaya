using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class Show : MonoBehaviour
{
    public GameObject Ghost;
    public Light A;
    public Light B;
    public Light C;
    public Light D;
    public CP2_Event cp2;
    public GameObject Sec;
    public GameObject img;
    public GameObject pp;

    public AudioSource EEEE;
    public AudioSource BOOM;
    public bool BOOOOOM;

    public float timeer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if (BOOOOOM == true)
            {
                BOOOOOM = false;
            }
            else
                BOOOOOM = true;
        }


        
        if ( BOOOOOM == true)
            BOOM.Play();


        if (Input.GetKeyDown(KeyCode.O))
        {
            
            cp2.LASTTP = true;
        }
            

        if (cp2.LASTTP == true)
        {
        
            
            StartCoroutine(Sshow());
           
           
        }
    }

    public IEnumerator Sshow()
    {
        A.intensity = 0;
        B.intensity = 0;
        C.intensity = 0;
        D.intensity = 0;
      
        yield return new WaitForSeconds(2f);
        EEEE.Play();
        A.intensity = 1;
        B.intensity = 1;//Ã³À½ Å´ ±Í½Å¾øÀ½
        C.intensity = 1;
        D.intensity = 1;
        
        Ghost.SetActive(false);
        yield return new WaitForSeconds(2f);
       
        A.intensity = 0;
       
        B.intensity = 0;
        C.intensity = 0;//ºÒ²¨Áö°í ±Í½Å ¾Õ
        D.intensity = 0;
        Ghost.transform.position = Sec.transform.position;
        Ghost.SetActive(true);
        yield return new WaitForSeconds(2f);
        EEEE.Play();
        A.intensity = 1;
        B.intensity = 1;//ºÒÄÑÁü
        C.intensity = 1;
       
        D.intensity = 1;
        Ghost.SetActive(false);

        for (int i = 0; i < 2; i++)
        {
            A.intensity = 0;
           
            B.intensity = 0;
            C.intensity = 0;
            D.intensity = 0;
         

       
            yield return new WaitForSeconds(2f);
            A.intensity = 1;
            B.intensity = 1;
            C.intensity = 1;
            D.intensity = 1;
            EEEE.Play();
           
        }

        yield return new WaitForSeconds(8f);


        img.SetActive(true);
        
        BOOOOOM = true;
        BOOOOOM = false;



        yield return null;
    }
}

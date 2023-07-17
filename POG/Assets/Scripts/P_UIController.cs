using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class P_UIController : MonoBehaviour // 플레이어 
{
    public Text I_key;
    public GameObject text;
    public bool IsCollision;
    public GameObject obj;

    public bool C2_1L;
    public bool C2_2Ready;
    public bool C2_2Run;
    public bool IsDie;
    public Animator animator;

    public GameObject P_obj;

    public O_UIController ouiController;
    public LightMaster Lmaster;
    public CP2_Event cp2;
    public AudioSource e1;
    public AudioSource LL;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCollision == true)
        {
            if (obj.layer == 10)
            {
                e1.Play();
                Debug.Log("REEEEE");
                C2_1L = true;
            }
            
            if (obj.layer == 11)
            {
                C2_2Run = true;
                StartCoroutine(BBB());
            }

            if (obj.layer == 12 && cp2.FINAL)
            {
                text.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Send");
                    IsDie = true;
                    text.SetActive(false);
                }
                else if (IsDie == true)
                {
                    text.SetActive(false);

                }


            }


            if (obj.name == "D_Collider" && IsCollision == true)
            {
                if (animator.GetBool("IsOpen") == false)
                {
                    text.SetActive(true);
                    I_key.text = "[E] 문열기";
                }                
                else
                {
                    text.SetActive(true);
                    I_key.text = "[E] 문닫기";
                }
            }
            else if (obj.layer == 8)
            {
                text.SetActive(true);
                I_key.text = "[E] 유물조사";
            }
                

            if (ouiController.IsRearn == true)
            {
                text.SetActive(true);
                I_key.text = "여는중";
            }
            if (ouiController.IsOpen == true)
            {
                text.SetActive(true);
                I_key.text = "";

            }
        }
        
    }

    private void OnTriggerStay(Collider other)

    {        
        IsCollision = true;
        obj = other.gameObject;
        if (obj.layer == 8 || obj.layer == 0) return;

        P_obj = obj.transform.parent.gameObject;
        
        animator = P_obj.GetComponent<Animator>();
    }

    private void OnTriggerExit(Collider other)

    {
        text.SetActive(false);
        IsCollision = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        
            
                
    }
    public IEnumerator BBB()
    {
        for (int i = 0; i < 2; i++)
        {

            Lmaster.llight.intensity = 0;
            Lmaster.Llight.intensity = 0;
            yield return new WaitForSeconds(.2f);
            Lmaster.hand.Play();
            Lmaster.llight.intensity = 0.4f;
            Lmaster.Llight.intensity = 0.4f;
            yield return new WaitForSeconds(.1f);
        }

        yield return new WaitForSeconds(.5f);

        Lmaster.llight.intensity = 0f;
        Lmaster.Llight.intensity = 0f;
        Lmaster.hand.Play();
        Lmaster.IsOn = false;


    }
}

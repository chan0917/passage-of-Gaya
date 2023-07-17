using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_AnimeController : MonoBehaviour //플레이어
{
    public Animator animator;
    public P_UIController uiController;
    public bool A_DoorOpen;
    public Light l;

    public AudioSource Rain;
    public AudioSource low;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (uiController.IsCollision == true)
        {
            if (uiController.obj.layer == 8) return;

            animator = uiController.P_obj.GetComponent<Animator>();

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (uiController.obj.layer == 8 || uiController.obj.layer == 12) return;
                if (animator.GetBool("IsOpen") == false)
                {
                    animator.SetBool("IsOpen", true);
                    A_DoorOpen = true;
                    Rain.Stop();
                    low.Play();

                }
                else
                {
                    animator.SetBool("IsOpen", false);
                    A_DoorOpen = false;
                    l.intensity = 0;
                }

            }
        }
        
    }
}

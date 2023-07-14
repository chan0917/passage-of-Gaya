using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_AnimeController : MonoBehaviour
{
    public Animator animator;
    public P_UIController uiController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator = uiController.P_obj.GetComponent<Animator>();

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(animator.GetBool("IsOpen") + " OpenDoor");
            if (animator.GetBool("IsOpen") == false)
            {
                animator.SetBool("IsOpen", true);
            }
            else
                animator.SetBool("IsOpen", false);
        }
    }
}

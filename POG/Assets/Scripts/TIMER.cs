using System.Collections;
using System.Collections.Generic;
using UnityEngine; //타이머와 tp관리 

public class TIMER : MonoBehaviour
{

    public float timer;
    public bool AA = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            AA = true;   
        }
        if (AA == true)
            timer += Time.deltaTime;

        Debug.Log(timer);
    }
}

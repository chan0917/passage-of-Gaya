using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L : MonoBehaviour
{
    public CP2_Event eevent;
    public GameObject gameobj;
    public GameObject pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (eevent.LASTTP == true)
        {
            gameobj.transform.position = pos.transform.position;

        }
    }
}

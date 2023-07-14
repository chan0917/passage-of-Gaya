using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCheck : MonoBehaviour
{
    public GameObject obj;
    public bool IsPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        obj = other.gameObject;

        if (obj.name == "Player")
            IsPlayer = true;
        else
            IsPlayer = false;
    }
}

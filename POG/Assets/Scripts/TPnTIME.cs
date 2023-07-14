using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TPnTIME : MonoBehaviour
{
    public float timer;
    public bool AA = false;
    public GameObject pos;
    public LightMaster lMaster;
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
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.transform.position = pos.transform.position; // ºÎµúÈù °´Ã¼¸¦ Å¸°ÙÀÇ À§Ä¡·Î º¸³½´Ù.
            AA = true;
            lMaster.llight.intensity = 0;
            lMaster.Llight.intensity = 0;
            lMaster.IsOn = false;
        }

    }

    


}

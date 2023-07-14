using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public bool IsNight;
    public GameObject SUN;
    public Light sunLight;

    public GameObject Dark;
    public GameObject Shine;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fog = false;
        IsNight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (IsNight == false)
            {
                IsNight = true;
                RenderSettings.fog = true;
                SUN.transform.rotation = Quaternion.Euler(new Vector3(-40f, 0f, 0f));
                sunLight.intensity = 0;
                Dark.SetActive(true);
                Shine.SetActive(false);
            }
            else if (IsNight == true)
            {
                IsNight = false;
                RenderSettings.fog = false;
                SUN.transform.rotation = Quaternion.Euler(new Vector3(45f, 0f, 0f));
                sunLight.intensity = 1;
                Dark.SetActive(false);
                Shine.SetActive(true);
            }
        }
    }
}

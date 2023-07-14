using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour //타임 마스터 
{
    public bool IsNight;
    public GameObject SUN;
    public Light sunLight;

    public GameObject Dark;
    public GameObject Shine;

    public Light L_1;
    public Light L_2;
    public Light L_3;

    public O_UIController ouiController;
    public LightMaster LMaster;

    public AudioSource Light;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fog = false;
        IsNight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ouiController.O_Dark == true && Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(GODark());
            ouiController.O_Dark = false;
        }
        if (Input.GetKeyDown(KeyCode.L))
            StartCoroutine(GODark());
    }

    public void OnOff() //처음 불끄는곳 
    {
        if (IsNight == false)
        {
            IsNight = true;
            RenderSettings.fog = true;
            SUN.transform.rotation = Quaternion.Euler(new Vector3(-40f, 0f, 0f));
            sunLight.intensity = 0;
            Dark.SetActive(true);
            Shine.SetActive(false);
            Light.Play();
            StartCoroutine(LMaster.TurnOn());
        }
        else if (IsNight == true)
        {
            IsNight = false;
            RenderSettings.fog = false;
            SUN.transform.rotation = Quaternion.Euler(new Vector3(45f, 0f, 0f));
            sunLight.intensity = 1;
            Dark.SetActive(false);
            Shine.SetActive(true);
            Light.Play();
            StartCoroutine(LMaster.TurnOn());
        }
    }

    public IEnumerator GODark()
    {
        L_1.intensity = 0;
        L_2.intensity = 0;
        L_3.intensity = 0;
        SUN.transform.rotation = Quaternion.Euler(new Vector3(-40f, 0f, 0f));
        sunLight.intensity = 0;
        yield return new WaitForSeconds(.35f);
        L_1.intensity = 1f;
        L_2.intensity = 1f;
        L_3.intensity = 1f;
        SUN.transform.rotation = Quaternion.Euler(new Vector3(45f, 0f, 0f));
        sunLight.intensity = 1;
        yield return new WaitForSeconds(.2f);

        for (int i = 0; i < 2; i++)
        {
            L_1.intensity = 0;
            L_2.intensity = 0;
            SUN.transform.rotation = Quaternion.Euler(new Vector3(-40f, 0f, 0f));
            sunLight.intensity = 0;
            L_3.intensity = 0;
            yield return new WaitForSeconds(.07f);
            L_1.intensity = 1f;
            L_2.intensity = 1f;
            L_3.intensity = 1f;
            SUN.transform.rotation = Quaternion.Euler(new Vector3(45f, 0f, 0f));
            sunLight.intensity = 1;
            yield return new WaitForSeconds(.07f);
        }
        OnOff();
        yield return null;
    }
}

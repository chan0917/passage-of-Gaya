using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMaster : MonoBehaviour
{
    private AudioSource BGM;

    [System.Serializable]
    public struct BgmType
    {
        public string name;
        public AudioClip audio;
    }
    public BgmType[] BGMList;

    // Start is called before the first frame update
    void Start()
    {
        BGM = gameObject.AddComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

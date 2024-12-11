using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoOnclick : MonoBehaviour
{

    private AudioSource music;
    public AudioClip ClickAudio;
   
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    public void ClickAudioOn()
    {
        music.PlayOneShot(ClickAudio);
    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
}

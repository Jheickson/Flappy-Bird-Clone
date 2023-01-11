using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSounds : MonoBehaviour
{

    [SerializeField] AudioClip[] flaps;
    [SerializeField] AudioClip[] dies;
    AudioSource myAudioSource;

    void Start()
    {

        myAudioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //if(Input.GetKeyDown(KeyCode.Space))
        //{

        //    Flaps();

        //}
        
    }

    public void Flaps()
    {

        AudioClip clip = flaps[UnityEngine.Random.Range(0, flaps.Length)];
        myAudioSource.PlayOneShot(clip);

    }

    public void Dies()
    {

        AudioClip clip = dies[UnityEngine.Random.Range(0, dies.Length)];
        myAudioSource.PlayOneShot(clip);

    }
}

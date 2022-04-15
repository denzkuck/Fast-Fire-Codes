﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript18 : MonoBehaviour
{

    private AudioSource audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        {
            audioSource.Play();
        }
    }
        

}

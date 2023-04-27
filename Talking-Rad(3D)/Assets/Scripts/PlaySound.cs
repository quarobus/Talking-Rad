using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    AudioSource animationSoundPlayer;
    void Start()
    {
        animationSoundPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PlaySoundMusic()
    {
        animationSoundPlayer.Play();
    }
}

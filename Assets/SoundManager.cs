using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip birdFlying;
    private static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        birdFlying = Resources.Load<AudioClip>("Sounds/BirdJump.wav");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound()
    {
        audioSrc.PlayOneShot(birdFlying);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip birdFlying;
    public static AudioClip birdGameOver;
    public static AudioClip birdScore;    
    private static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        birdFlying = Resources.Load<AudioClip>("BirdJump");
        birdGameOver = Resources.Load<AudioClip>("Lose");
        birdScore = Resources.Load<AudioClip>("Score");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlayFlyingSound()
    {
        audioSrc.PlayOneShot(birdFlying);
    }

    public static void PlayGameOverSound()
    {
        audioSrc.PlayOneShot(birdGameOver);
    }

    public static void PlayScoreSound()
    {
        audioSrc.PlayOneShot(birdScore);
    }
}

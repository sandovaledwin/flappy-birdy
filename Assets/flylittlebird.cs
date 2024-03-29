﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flylittlebird : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager.start();
        SoundManager.PlayScoreSound();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
            SoundManager.PlayFlyingSound();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.gameOver();
        SoundManager.PlayGameOverSound();
    }
}

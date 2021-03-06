﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite inactiveButton;
    public Sprite hoveringButton;
    public Sprite pressedButton;
    private bool pressed;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseOver()
    {
        if (!pressed)
        {
            spriteRenderer.sprite = hoveringButton;
        }
    }

    void OnMouseExit()
    {
        spriteRenderer.sprite = inactiveButton;
    }

    void OnMouseDown()
    {
        pressed = true;
        spriteRenderer.sprite = pressedButton;
        SceneManager.LoadScene(sceneName:"Level");
    }

    void OnMouseUp()
    {
        spriteRenderer.sprite = hoveringButton;
        pressed = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puppe : MonoBehaviour
{

    [SerializeField] Sprite dollLeft;
    [SerializeField] Sprite dollMid;
    private float timer;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        timer = 10f;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            spriteRenderer.sprite = dollMid;
            timer = 10f;
        }

        if (timer <= 8)
        {
            spriteRenderer.sprite = dollLeft;
        }
    }

}

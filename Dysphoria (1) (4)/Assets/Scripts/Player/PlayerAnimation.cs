using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Player player;
    private Animator anim;
    private DemonMode demonMode;

    private void Awake()
    {
        demonMode = FindObjectOfType<DemonMode>();
        anim = GetComponent<Animator>();
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {

        if (player.isGrabbing == true)
        {
            anim.SetBool("isGrabbing", true);
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isGrabbing", false);
        }


        if (player.isWalking && !demonMode.inDemonMode && player.hasClothes)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("hasClothes", true);
            anim.SetBool("isDemon", false);
        }
        else if (!player.isWalking && !demonMode.inDemonMode && player.hasClothes)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("hasClothes", true);
            anim.SetBool("isDemon", false);
        }

        else if (!player.isWalking && demonMode.inDemonMode)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isDemon", true);
        }
        else if (player.isWalking && demonMode.inDemonMode)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isDemon", true);
        }

        else if (!player.isWalking && !demonMode.inDemonMode && !player.hasClothes)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("hasClothes", false);
            anim.SetBool("isDemon", false);
        }
        else if (player.isWalking && !demonMode.inDemonMode && !player.hasClothes)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("hasClothes", false);
            anim.SetBool("isDemon", false);
        }


        if (player.isGrabbing == true)
        {
            Invoke("StopGrabAnim", 0.5f);
        }

    }

    private void StopGrabAnim()
    {
        player.isGrabbing = false;
    }

}

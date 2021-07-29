using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoyer_camera_shake : MonoBehaviour
{
    public Animator camera_shack;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
           camera_shack.SetBool("isdead", true);
        }

    }
}

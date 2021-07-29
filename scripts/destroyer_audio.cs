using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer_audio : MonoBehaviour
{
    public AudioSource explosion;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            explosion.Play();
            FindObjectOfType<player_collision>().do_all_of_it();
            
        }   
    }
    
    
}

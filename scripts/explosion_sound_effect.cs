using UnityEngine.Audio;
using UnityEngine;

public class explosion_sound_effect : MonoBehaviour
{
    public AudioSource explosion;
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        explosion.enabled = true;  
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_conter : MonoBehaviour
{
    public static int score=0;
    public static int best_scoree;
    public int t=best_scoree;
    private static int a = 0;
    public AudioSource onpoint;
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
        score++;
        
        onpoint.Play();
        Destroy(gameObject, 0.3f);
        }
        if(a==0)
        { 
        best_scoree = score;
            a++;
        }
        if(score > best_scoree && a>0)
        {

            best_scoree = score;
            
        }
        
        if (spawner.obstical_conter > 5)
        {
            spawner.height = 3;
        }
        if (spawner.obstical_conter > 20)
        {
            spawner.height = 3.5f;
            spawner.speed = 6;
        }
        if (spawner.obstical_conter > 30)
        {
            spawner.height = 4.5f;
        }
        if (spawner.obstical_conter > 40)
        {
            spawner.height = 5.5f;
            spawner.speed = 5;
        }
        if (spawner.obstical_conter > 50)
        {
            spawner.height = 6.5f;
        }
        if (spawner.obstical_conter > 65)
        {
            spawner.speed = 4;
        }
    }
}

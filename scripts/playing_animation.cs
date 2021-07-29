using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playing_animation : MonoBehaviour
{
  
   
    public Animator anim;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        anim.SetBool("isclose", true);
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("isclose", false);
       
    }
    
    
}

using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public GameObject game_menu;
    public GameObject we_dont_need_you;
    public GameObject partical;
    public Animator camera_shack;
    public movement mov;
    public camera_folow cam_flo;
    public spawner span;
    public back_ground_moving back_move;

    public int i = score_conter.best_scoree;
   
    public void OnCollisionEnter2D(Collision2D collisionn)
    {
            
       if(collisionn.collider.tag=="obstical")
        {
            camera_shack.SetBool("isdead", true);
            FindObjectOfType<movement>().enabled = false;
            mov.enabled = false;  
            cam_flo.enabled = false;       
            span.enabled = false;
            back_move.enabled = false;
            Destroy(gameObject);
            partical.transform.position = transform.position;
            partical.SetActive(true);
            game_menu.SetActive(true);
            we_dont_need_you.SetActive(false);
            low_high.select_menu = true;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision1)
    {
        if(collision1.tag=="destroyer")
        {
            camera_shack.SetBool("isdead", true);
            mov.enabled = false;
            cam_flo.enabled = false;
            span.enabled = false;
            back_move.enabled = false;
            Destroy(gameObject);
            partical.transform.position = transform.position;
            partical.SetActive(true);
            game_menu.SetActive(true);
            we_dont_need_you.SetActive(false);
            low_high.select_menu = true;
        }
        
     }

    public void do_all_of_it()
    {
        mov.enabled = false;
        cam_flo.enabled = false;
        span.enabled = false;
        back_move.enabled = false;
        Destroy(gameObject);
        partical.transform.position = transform.position;
        partical.SetActive(true);
        game_menu.SetActive(true);
        we_dont_need_you.SetActive(false);
    }

}

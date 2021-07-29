using UnityEngine.Audio;
using UnityEngine;

public class movement : MonoBehaviour
{
    //public AudioSource right, left;
    public AudioClip rig,lft;
    public Rigidbody2D rb;
    public GameObject start_back_ground;
    public int x_force, y_force;
    public bool game_hase_started=false;
    public AudioSource Right,Left;
    private Vector3 POS;
 
    void Update()
    {
      if(low_high.select_menu==false)
      {
        
        FindObjectOfType<destroyer_audio>().enabled = true;
        if (Input.GetKeyDown("d"))
        {
                Right.Play();
            if(game_hase_started==false)
            {
                Time.timeScale = 1;
                game_hase_started = true;
                start_back_ground.SetActive(false);
            }
            rb.AddForce(new Vector2(x_force * Time.deltaTime, y_force * Time.deltaTime), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown("q"))
        {
            Left.Play();
            if (game_hase_started == false)
            {
                Time.timeScale = 1;
                game_hase_started = true;
                start_back_ground.SetActive(false);
            }
            rb.AddForce(new Vector2(-x_force * Time.deltaTime, y_force * Time.deltaTime), ForceMode2D.Impulse);
        }

       }
    }
}

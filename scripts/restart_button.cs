using UnityEngine.SceneManagement;
using UnityEngine;

public class restart_button : MonoBehaviour
{
   
    public void restart()
    {
       
        FindObjectOfType<explosion_sound_effect>().explosion.enabled = false;
        spawner.height = 2.5f;
        spawner.obstical_conter = 0;
        spawner.speed = 7;
        score_conter.score = 0;
        SceneManager.LoadScene(1);
       // Time.timeScale = 1;
       
    }
    public void Main_menu()
    {
      
        FindObjectOfType<explosion_sound_effect>().explosion.enabled = false;
        spawner.height = 2.5f;
        spawner.obstical_conter = 0;
        spawner.speed = 7;
        score_conter.score = 0;
        SceneManager.LoadScene(0);
    }
}

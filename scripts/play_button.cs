using UnityEngine.SceneManagement;
using UnityEngine;

public class play_button : MonoBehaviour
{
   
    public void play()
    {
        
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        Application.Quit();
    }
}

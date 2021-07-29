using UnityEngine.UI;
using UnityEngine;

public class best_score : MonoBehaviour
{
    public Text best_player_score;
    int i;
    
    void Update()
    {
        i = score_conter.best_scoree;
        if(i>PlayerPrefs.GetInt("high_score"))
        {

        PlayerPrefs.SetInt("high_score",i);
        }
      
        best_player_score.text = PlayerPrefs.GetInt("high_score").ToString();
    }
    

}

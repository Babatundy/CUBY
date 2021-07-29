using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    public Text player_score;

   
    void Update()
    {
        player_score.text = score_conter.score.ToString();
    }
}

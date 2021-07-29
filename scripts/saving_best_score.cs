using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class saving_best_score 
{
    public int Best_score;
    public saving_best_score(player_collision bestscoree)
    {

        Best_score = bestscoree.i;
    }
}

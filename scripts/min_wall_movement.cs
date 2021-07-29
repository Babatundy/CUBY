using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class min_wall_movement : MonoBehaviour
{
    public Transform player_pos;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        
       
            transform.position =new Vector3(0, player_pos.position.y+offset,0);
       
    }
}

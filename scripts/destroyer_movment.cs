using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer_movment : MonoBehaviour
{
    public Transform player_posistion;
    
    private void Start()
    {
        transform.position = player_posistion.position;
    }
    void Update()
    {
        if(player_posistion!=null)
        {

        transform.position = new Vector3(0, player_posistion.position.y, -10);
        }
    }
   
}

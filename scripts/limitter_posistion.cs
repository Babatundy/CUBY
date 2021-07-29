using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitter_posistion : MonoBehaviour
{
    public Transform cam_pos;
    void Update()
    {
        transform.position = new Vector3(0, 3, -10)+cam_pos.position;  
    }
}

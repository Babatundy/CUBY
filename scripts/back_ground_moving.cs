using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back_ground_moving : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset;
    void Update()
    {
        transform.position = player.transform.position+offset;
    }
}

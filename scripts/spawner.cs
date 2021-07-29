using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipe;
    public GameObject player;
    public float maxTime = 1;
    private float timer = 0;
    public static float height=2.5f;
    public static int speed=7;
    public static int obstical_conter = 0;

    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(Random.Range(-height, height), 0, 0);
    }
    void Update()
    {
        if(timer>maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(Random.Range(-height, height), 0, 0);
            Destroy(newpipe, 180);
            timer = 0;
            obstical_conter++;

        }
        timer += Time.deltaTime;
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}

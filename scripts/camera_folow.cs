using UnityEngine.SceneManagement;
using UnityEngine;

public class camera_folow : MonoBehaviour
{
   
    public GameObject player,trigger_limit,ok/*tthis is a reference tothe camra*/;
    public Vector3 offset;
    private Vector3 limit, player_position,trigger_position;

    private void LateUpdate()
    {
        player_position = player.transform.position;
        if(limit.y<=player_position.y)
        {
            limit = player_position;
        }
    }
    private void Start()
    {
        limit = transform.position;
        trigger_position = limit;
    }
    private void Awake()
    {
        Time.timeScale = 0;
    }
    
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        ok.transform.position = new Vector3(0,player.transform.position.y,offset.z) ;
       //if(trigger_position.y<=player_position.y)
        //{
           // limit.y = player_position.y;
        transform.position = new Vector3(0, limit.y, 0);
        //}
       
    }

   


}

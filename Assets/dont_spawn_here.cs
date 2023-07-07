using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dont_spawn_here : MonoBehaviour
{
    public GameObject obj;
    public obstacle_script obs_scr;
    public moving mov;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "enemy")
        {
            col.GetComponent<obstacle_script>().can_move = false;
        }   
    }
    void OnTriggerStay(Collider col) 
    {
        if (col.gameObject.tag == "enemy")
        {
            col.GetComponent<obstacle_script>().can_move = false;
        }  
    }

    void FixedUpdate()
    {
        if (!mov.is_game_end)
        {
            obs_scr.speed_coef += 0.00005f;
            transform.localScale = new Vector3(transform.localScale.x + 0.001f, 1, 1);
            transform.position = obs_scr.transform.position;
            transform.position = new Vector3(transform.position.x + (transform.localScale.x * 0.5f) + 0.5f, transform.position.y, transform.position.z);
        }
    }
}

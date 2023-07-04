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
            obs_scr.can_move = false;
        }   
    }
    void OnTriggerStay(Collider col) 
    {
        if (col.gameObject.tag == "enemy")
        {
            obs_scr.can_move = false;
        }  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!mov.is_game_end)
        {
            obs_scr.speed_coef += 0.00001f;
            transform.position = obs_scr.transform.position;
            transform.position = new Vector3(transform.position.x + 2.5f, transform.position.y, transform.position.z);
        }
    }
}

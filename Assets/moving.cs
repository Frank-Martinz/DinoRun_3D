using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moving : MonoBehaviour
{
    public GameObject obj;
    Rigidbody player;
    private bool is_ground = false;
    public bool is_game_end = false;
    public bool is_game_paused = false;
    public obstacle_script obs_scr;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground") {is_ground = true;}
        if (collision.gameObject.tag == "enemy") 
        {
            is_game_end = true;    
            player.freezeRotation = false;
            player.AddForce(Vector3.right * 3 * obs_scr.speed_coef, ForceMode.Impulse);
        }
    }

    void Update()
    {
        if (!is_game_end && !is_game_paused)
        {
            if(Input.GetKeyDown(KeyCode.Space) && is_ground) 
            {
                is_ground = false;
                player.AddForce(Vector3.up * 7, ForceMode.Impulse); 
            }
        }
        
    }
    public void set_unset_pause()
    {
        if (is_game_paused is false) {is_game_paused = true;}
        else {is_game_paused = false;}
        if (is_game_paused){Time.timeScale = 0; }
        else {Time.timeScale = 1;}
    }
}

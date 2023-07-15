using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class obstacle_script : MonoBehaviour
{
    public GameObject obj;
    Rigidbody enemy;
    private System.Random rnd = new System.Random();
    public float speed_coef = 1f;
    public moving mov;
    public bool can_move = true;
    public float score = 0f;
    private float pre_score = 0f;
    void Start()
    {
        enemy = GetComponent<Rigidbody>();
        transform.position = new Vector3(GetRandomNumber(), 2.5f, transform.position.z);
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "enemy")
        {
            transform.position = new Vector3(GetRandomNumber(), 2.5f, transform.position.z);
        }
    }
    void FixedUpdate()
    {
        if (!mov.is_game_end && !mov.is_game_paused)
        {
            speed_coef += 0.0003f;
            if (can_move)
            {
                pre_score = -3 * speed_coef * Time.deltaTime * -1;
                transform.position = transform.position + new Vector3(-3 * speed_coef, 0, 0) * Time.deltaTime;
                if (pre_score > 0) {score += pre_score;}
                if (transform.position.x < -7)
                {
                    transform.position = new Vector3(GetRandomNumber(), 1.5f, transform.position.z);
                }
            }
        }
        can_move = true;
    }

    public int GetRandomNumber()
    {
        return rnd.Next(15, Convert.ToInt32(50 + (speed_coef * 20)));
    }
}

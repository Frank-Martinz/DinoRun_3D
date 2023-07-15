using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restart_but : MonoBehaviour
{
    [SerializeField] private GameObject restart;
    [SerializeField] private GameObject exit;
    public moving mov;
    public Canvas esc_menu;
    public canvas_esc_menu can_esc_men;
    void Start()
    {
        GameObject.Find("Restart_button").GetComponentInChildren<Text>().text = "Restart";
        GameObject.Find("Restart_button").GetComponentInChildren<Text>().color = new Color(255, 0, 0);
        GameObject.Find("Exit_button").GetComponentInChildren<Text>().text = "Exit";
        GameObject.Find("Exit_button").GetComponentInChildren<Text>().color = new Color(255, 0, 0);
        restart.SetActive(false); 
        exit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {  
            esc_menu.gameObject.SetActive(!esc_menu.gameObject.activeSelf);
            this.gameObject.SetActive(!this.gameObject.activeSelf);
            can_esc_men.Pause_or_resume();
        }
        if (mov.is_game_end)
        {
            restart.SetActive(true);
            exit.SetActive(true);
        }
    }
}

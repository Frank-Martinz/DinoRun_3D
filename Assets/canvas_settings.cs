using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restart_but : MonoBehaviour
{
    [SerializeField] private GameObject restart;
    [SerializeField] private GameObject exit;
    public moving mov;
    // Start is called before the first frame update
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
        if (mov.is_game_end)
        {
            restart.SetActive(true);
            exit.SetActive(true);
        }
    }
}

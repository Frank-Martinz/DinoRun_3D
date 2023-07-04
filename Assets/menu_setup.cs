using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_setup : MonoBehaviour
{
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject settings;
    [SerializeField] private GameObject exit;
    void Start()
    {
        GameObject.Find("Start_but").GetComponentInChildren<Text>().text = "Start";
        GameObject.Find("Settings_but").GetComponentInChildren<Text>().text = "Settings";
        GameObject.Find("Exit_but").GetComponentInChildren<Text>().text = "Exit";
    }

    // Update is called once per frame
    void Update()
    {

    }
}

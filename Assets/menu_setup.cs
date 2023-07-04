using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_setup : MonoBehaviour
{
    [SerializeField] private GameObject start;
    void Start()
    {
        GameObject.Find("Start_but").GetComponentInChildren<Text>().text = "Start";
        GameObject.Find("Settings_but").GetComponentInChildren<Text>().text = "Settings";
    }

    // Update is called once per frame
    void Update()
    {

    }
}

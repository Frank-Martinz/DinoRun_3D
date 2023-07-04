using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Canvas menu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Open_menu();
        }
    }
    void Open_menu()
    {
        menu.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

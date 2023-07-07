using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class for_settings : MonoBehaviour
{
    public Dropdown resolution;
    public Dropdown display_mode;
    public Button apply;
    private bool smth_changed = false;
    public void Smth_changed()
    {
        smth_changed = true;
        apply.gameObject.SetActive(true);
        GameObject.Find("apply_btn").GetComponentInChildren<Text>().text = "Apply";
    }
    public void Apply_Changes()
    {
        bool full_screen = true;
        if (display_mode.value == 0) {full_screen = true;}
        else {full_screen = false;}

        string[] res = resolution.options[resolution.value].text.Split("×");
        Screen.SetResolution(Convert.ToInt32(res[0]), Convert.ToInt32(res[1]), full_screen);
        apply.gameObject.SetActive(false);
    }
    
}

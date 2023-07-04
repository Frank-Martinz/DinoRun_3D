using System.Collections;
using System.Collections.Generic;
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

        if (resolution.value == 0)
        {
            Screen.SetResolution(1920, 1080, full_screen);
        }
        else if (resolution.value == 1)
        {
            Screen.SetResolution(1366, 768, full_screen);
        }
        else if (resolution.value == 2)
        {
            Screen.SetResolution(2560, 1440, full_screen);
        }
        apply.gameObject.SetActive(false);
    }
    
}

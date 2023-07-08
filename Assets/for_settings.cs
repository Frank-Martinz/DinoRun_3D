using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class for_settings : MonoBehaviour
{
    public Dropdown resolution;
    public Dropdown display_mode;
    public Slider volume;
    public InputField volume_input;
    public Button apply;

    private bool smth_changed = false;
    public void Smth_changed()
    {
        smth_changed = true;
        apply.gameObject.SetActive(true);
        GameObject.Find("apply_btn").GetComponentInChildren<Text>().text = "Apply";
    }
    public void Slider_moved()
    {
        Smth_changed();
        volume_input.SetTextWithoutNotify(volume.value.ToString());   
    }
    public void Input_changed()
    {
        Smth_changed();
        try
        {   
            int vol = Convert.ToInt32(volume_input.text);
            if (vol > 100){vol = 100;}
            else if (vol < 0) {vol = 0;}
            volume.SetValueWithoutNotify(vol);
            volume_input.SetTextWithoutNotify(vol.ToString());
        }
        catch (System.FormatException)
        {
            volume.SetValueWithoutNotify(0);
            if (volume_input.text != ""){volume_input.SetTextWithoutNotify("0");}
        }
    }
    public void Apply_Volume()
    {
        volume_input.SetTextWithoutNotify(volume.value.ToString());
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

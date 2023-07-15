using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_esc_menu : MonoBehaviour
{
    public Canvas main_canvas;
    public obstacle_script obs_scr;
    public moving mov;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            main_canvas.gameObject.SetActive(!main_canvas.gameObject.activeSelf);
            this.gameObject.SetActive(!this.gameObject.activeSelf);
            Pause_or_resume();
        }
    }
    public void Pause_or_resume()
    {
        mov.set_unset_pause();
    }
}

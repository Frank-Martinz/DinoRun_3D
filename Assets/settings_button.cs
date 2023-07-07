using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings_button : MonoBehaviour
{
    public Canvas graphic;
    public Canvas audio;
    public Canvas mouse_and_keyboard;

    public void make_available(string tag = "graphic")
    {
        graphic.gameObject.SetActive(false);
        audio.gameObject.SetActive(false);
        mouse_and_keyboard.gameObject.SetActive(false);
        if (tag == "graphic"){graphic.gameObject.SetActive(true);}
        if (tag == "audio"){audio.gameObject.SetActive(true);}
        if (tag == "m_k"){mouse_and_keyboard.gameObject.SetActive(true);}

    }
}

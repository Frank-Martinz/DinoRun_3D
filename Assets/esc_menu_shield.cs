using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class esc_menu_shield : MonoBehaviour
{
    public Image menu_shield;

    void Update()
    {
        menu_shield.rectTransform.localScale = new Vector3(Screen.width, Screen.height, 0);
    } 
}

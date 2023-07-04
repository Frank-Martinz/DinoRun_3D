using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_over_shiled : MonoBehaviour
{
    public Image img;
    public moving mov;
    private float a = 0f;
    void Update()
    {
        if (mov.is_game_end)
        {
            if (a < 1f)
            {
                a += 0.001f;
                img.color = new Color(0, 0, 0, a);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public Text game_over;
    public moving mov;
    public Canvas canva;
    void Start()
    {
        game_over.text = "";
    }

    void Update()
    {
        if (mov.is_game_end)
        {
            game_over.text = "GAME\nOVER";
        }
    }
}

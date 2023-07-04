using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result_counting : MonoBehaviour
{
    public Text score;
    public obstacle_script obs_scr;
    public moving mov;
    void Update()
    {
       score.text = $"{(int)obs_scr.score}";
    }
}

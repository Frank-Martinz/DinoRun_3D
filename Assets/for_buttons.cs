using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class for_buttons : MonoBehaviour
{
    public void Restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Exit_game()
    {
        Application.Quit();
    }
    public void Start_game()
    {
        SceneManager.LoadScene("Game");
    }
}

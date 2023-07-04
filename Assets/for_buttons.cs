using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class for_buttons : MonoBehaviour
{
    public Canvas settings;
    public Canvas menu;
    public void Restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Exit_game()
    {
        Application.Quit();
    }
    public void Return_to_menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Start_game()
    {
        SceneManager.LoadScene("Game");
    }
    public void Open_settings()
    {
        settings.gameObject.SetActive(true);
        menu.gameObject.SetActive(false);
    }
}

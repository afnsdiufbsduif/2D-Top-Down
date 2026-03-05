using System;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool PauseGame;

    public GameObject pauseGameMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        Debug.Log("Игра на паузе");
        pauseGameMenu.SetActive(true);
        Debug.Log("pauseGameMenu активен: " + pauseGameMenu.activeSelf);
        Time.timeScale = 0f;
        PauseGame = true;
    }


    public void Resume()
    {
        Debug.Log("Игра возоб");
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Игра закрыта");
    }
}

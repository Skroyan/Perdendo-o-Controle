using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool pause = false;
    public GameObject menu;

    public void Resume()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }
    void Pause()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}

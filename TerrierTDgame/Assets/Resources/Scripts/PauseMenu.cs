using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isPaused = false;
    public GameObject PauseMenuUI;
    public GameObject QuitUI;
    // Update is called once per frame
    public SpriteRenderer sprite;
    public int sec;
    void Start()
    {
        sec = 0;
        PauseMenuUI.SetActive(false);
        QuitUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void resume()
    {
        PauseMenuUI.SetActive(false);
        QuitUI.SetActive(false);

        Time.timeScale = 1f;
        isPaused = false;
    }

    public void pause()
    {
        PauseMenuUI.SetActive(true);
        QuitUI.SetActive(true);

        Time.timeScale = 0f;
        isPaused = true;
    }

    public void quit()
    {
        Time.timeScale = 1f;
        isPaused = false;

    }

}
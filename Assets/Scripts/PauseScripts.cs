using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScripts : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUi;
    public GameObject pauseMenuUi1;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else Cursor.lockState = CursorLockMode.Locked;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        pauseMenuUi1.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        pauseMenuUi1.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeButton()
    {
        pauseMenuUi.SetActive(false);
        pauseMenuUi1.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void MenuButton(int NumberScenes)
    {
        SceneManager.LoadScene(NumberScenes);
    }
}

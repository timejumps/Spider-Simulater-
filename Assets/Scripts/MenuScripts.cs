using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    public void Scene(int NumberScenes)
    {
        SceneManager.LoadScene(NumberScenes);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

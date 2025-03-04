using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject sceneSelectMenu;
    
    public void LoadSceneScene(int sceneIndex)
    {
        Debug.Log("Trying to Load Scene " + sceneIndex);
        SceneManager.LoadScene(sceneIndex);
    }

    public void SceneSelector()
    {
        if (mainMenu.activeSelf)
        {
            mainMenu.SetActive(false);
            sceneSelectMenu.SetActive(true);
        }
        else
        {
            mainMenu.SetActive(true);
            sceneSelectMenu.SetActive(false);
        }
    }

    public void AppExit()
    {
        Application.Quit();
    }
}

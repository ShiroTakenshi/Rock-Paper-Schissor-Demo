using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    // TODO berganti scene
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        Debug.Log("Ini adalah Scene ke-" + sceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

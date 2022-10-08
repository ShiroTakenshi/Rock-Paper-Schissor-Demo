using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenRes : MonoBehaviour
{
    // [SerializeField] Toggle toggle;
    // public void QuitGame()
    // {
    //     Application.Quit();
    // }

    List<int> widths = new List<int>() { 1366, 1280, 1024, 800 };
    List<int> heights = new List<int>() { 768, 720, 768, 600 };

    public void SetScreenSize(int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);
        Screen.SetResolution(width, height, fullscreen);
        Debug.Log("Resolusi Layar Diganti" + (width, height));
    }

    // public void SetFullscreen(bool _fullscreen)
    // {
    //     Screen.fullScreen = _fullscreen;
    //     if (toggle.isOn == true)
    //         Debug.Log("Screen Maximize");
    //     else
    //         Debug.Log("Screen Minimize");
    // }
}

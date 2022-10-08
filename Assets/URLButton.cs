using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLButton : MonoBehaviour
{

    public void OpenURL()
    {
        Application.OpenURL("https://discord.gg/CmqU3tQY");
        Debug.Log("Play menekan Discord!");
    }

}

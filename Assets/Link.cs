using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    public void OpenURL()
    {
        Application.OpenURL("https://www.instagram.com/naufal_s.a/");
        Debug.Log("Play menekan Instagram!");
    }
}

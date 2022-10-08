using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UIController : MonoBehaviour
{
    public Slider _Musicslider, _SfxSlider;

    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSFX();
    }

    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_Musicslider.value);
    }

    public void SfxVolume()
    {
        AudioManager.Instance.SFXVolume(_SfxSlider.value);
        Debug.Log(_SfxSlider);
    }
}

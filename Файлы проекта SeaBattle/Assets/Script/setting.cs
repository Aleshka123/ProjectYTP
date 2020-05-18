using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class setting : MonoBehaviour
{
    Resolution[] rsl;
    List<string> resolutions;
    public Dropdown dropdown;
    public Dropdown DropDown;
    private bool isFullScreen;

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }

    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }

    public void Awake()
    {
        resolutions = new List<string>();
        rsl = Screen.resolutions;
        foreach (var i in rsl)
            resolutions.Add(i.width + "x" + i.height);
        dropdown.ClearOptions();
        dropdown.AddOptions(resolutions);
    }

    public void DropD()
    {
        if(DropDown.value == 0)
            Screen.SetResolution(1920, 1080, true);
        if (DropDown.value == 1)
            Screen.SetResolution(1280, 720, true);
        if (DropDown.value == 2)
            Screen.SetResolution(854, 480, true);
    }
}

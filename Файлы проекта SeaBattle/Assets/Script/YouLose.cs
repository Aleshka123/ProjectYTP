using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLose : MonoBehaviour
{
    public float Time;

    void Start()
    {
        Invoke("LoadMenu", Time);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Leveling");
    }
}

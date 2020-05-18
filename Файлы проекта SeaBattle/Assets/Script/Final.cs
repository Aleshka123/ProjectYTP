using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public float Time;

    void Start()
    {
        Invoke("LoadMenu", Time);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

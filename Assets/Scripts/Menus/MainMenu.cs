using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.SetInt("time", 0);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("LoadMainScenestoredSize" + PlayerPrefs.GetInt("size"));
    }
    public void Quit()
    {
        Application.Quit();
    }
}

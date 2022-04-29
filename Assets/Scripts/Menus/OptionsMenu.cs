using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    public Slider sizeSlider;
    public Text sizetext;
    public Slider obstacleSlider;
    public Text obstacletext;
    public void SetSize()
    {
        int size = (int)((sizeSlider.value * 5) + 10);

        sizetext.text = "Board Size: " + size;
        PlayerPrefs.SetInt("size", size);

        Debug.Log("size" + size);
        Debug.Log("storedSize" + PlayerPrefs.GetInt("size"));
    }
    public void SetObstacles()
    {
        int obstaclesNum = (int)(obstacleSlider.value * Mathf.Pow(((sizeSlider.value * 4) + 8), 2));

        obstacletext.text = "Number of Obstacles: " + obstaclesNum;
        PlayerPrefs.SetInt("obstacles", obstaclesNum);

        Debug.Log("obstacles" + obstaclesNum);
        Debug.Log("storedObstacles" + PlayerPrefs.GetInt("obstacles"));
    }
}

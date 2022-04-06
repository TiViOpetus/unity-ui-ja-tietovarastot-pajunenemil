using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    private int ScoreCount;
    // Start is called before the first frame update
    void Start()
    {
        ScoreCount = PlayerPrefs.GetInt("Score", 0);
        ScoreText.text = ScoreCount.ToString();
    }


    public void addScore()
    {
        ScoreCount++;
        ScoreText.text = ScoreCount.ToString();
        PlayerPrefs.SetInt("Score", ScoreCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

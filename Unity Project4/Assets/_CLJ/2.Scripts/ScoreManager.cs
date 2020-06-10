using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;                    //텍스트메시프로 사용시

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance = null;

    [HideInInspector] public int score = 0;
    private int highScore = 0;

    public Text scoreTxt;               //일반 UI 텍스트
    public Text highScoreTxt;           //일반 UI 텍스트
    public TextMeshProUGUI testTxt;         //텍스트메시프로 텍스트

    public GameObject boss;

    private void Awake() => instance = this;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreTxt.text = "High Score : " + highScore.ToString("0");
    }

    private void Update()
    {
        if(score > 10)
        {
            boss.SetActive(true);
        }
    }

    public void EnemyKill()
    {
        score++;
        scoreTxt.text = "Score : " + score.ToString("0");

        testTxt.text = "Test :" + score.ToString("0");

        if (highScore < score)
        {
            highScore++;
            highScoreTxt.text = "High Score : " + highScore.ToString("0");

            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}

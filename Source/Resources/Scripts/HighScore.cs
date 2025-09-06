using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    Text scoreText, highScoreText;
    public int SCORE;
    public int HIGH_SCORE;
    //string FORMATTED_SCORE;
    //float ONES, TENS, HUNDREDS, THOUSANDS, T_THOUSANDS, H_THOUSANDS, MILLIONS;
    void Start()
    {
        scoreText = GameObject.Find("SCORE_VALUE").GetComponent<Text>();
        highScoreText = GameObject.Find("HIGH_SCORE_VALUE").GetComponent<Text>();

        SaveData saveData = SaveSystem.LoadGameData();

        highScoreText.text = saveData.scoreData.score.ToString();
        HIGH_SCORE = saveData.scoreData.score;
    }

    private void OnEnable()
    {     
        InvokeRepeating(nameof(IncrementScore), 0.1f, 0.1f);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(IncrementScore));
    }

    private void IncrementScore()
    {
        SCORE++;

        scoreText.text = SCORE.ToString();
    }

    void Update()
    {
        //Debug.Log(Int16.Parse(scoreText.text));
        //SCORE += 1;

        //scoreText.text = SCORE.ToString();

        //ONES += (int)Time.deltaTime;

        //if (ONES >= 10)
        //{
        //    TENS++;
        //    ONES = 0;
        //}
        //else if (TENS >= 10)
        //{
        //    HUNDREDS++;
        //    TENS = 0;
        //}
        //else if (HUNDREDS >= 10)
        //{
        //    THOUSANDS++;
        //    HUNDREDS = 0;
        //}
        //else if (THOUSANDS >= 10)
        //{
        //    T_THOUSANDS++;
        //    THOUSANDS = 0;
        //}
        //else if (T_THOUSANDS >= 10)
        //{
        //    H_THOUSANDS++;
        //    T_THOUSANDS = 0;
        //}
        //else if (H_THOUSANDS >= 10)
        //{
        //    MILLIONS++;
        //    H_THOUSANDS= 0;
        //}

        //scoreText.text = MILLIONS.ToString() + H_THOUSANDS.ToString() +
        //    T_THOUSANDS.ToString() + THOUSANDS.ToString() + HUNDREDS.ToString() + TENS.ToString() + ONES.ToString();

        //Debug.Log("SCORE: " + MILLIONS.ToString() + H_THOUSANDS.ToString() +
        //    T_THOUSANDS.ToString() + THOUSANDS.ToString() + HUNDREDS.ToString() + TENS.ToString() + ONES.ToString());
    }
}

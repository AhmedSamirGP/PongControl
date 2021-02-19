using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager: MonoBehaviour
{
    public TMP_Text text1;
    public TMP_Text text2;
    private int score = 0;
    private int score2 = 0;
    private void OnIncreaseScore1()
    {
        score += 1;
        text1.text = score.ToString();
    }
    private void OnIncreaseScore2()
    {
        score2 += 1;
        text2.text = score2.ToString();
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public TMP_Text text1;
    public TMP_Text text2;
    //[SerializeField] IntSO scoreSO;
    private int score = 0;
 

    private void OnIncreaseScore1()
    {
        score += 1;
   
  
        text1.text = score.ToString();
    }
    private void OnIncreaseScore2()
    {
        score += 1;


        text1.text = score.ToString();
    }
}
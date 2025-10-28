using UnityEngine;
using TMPro; 

public class ScoreLoader : MonoBehaviour
{
    
    public TextMeshProUGUI scoreDisplay;

    // PlayerPrefs�� �����ߴ� Ű �̸�
    public const string LAST_SCORE_KEY = "LastMiniGameScore";


    void Start()
    {
        LoadAndDisplayScores();        
    }

    private void LoadAndDisplayScores()
    {
        // 1. ������ ���� �ҷ�����
        int lastScore = PlayerPrefs.GetInt(LAST_SCORE_KEY, 0);


  

            if (scoreDisplay != null)
        {
            scoreDisplay.text =
                $"Last Score: {lastScore}\n";
        }
        else
        {
            
        }
    }
}
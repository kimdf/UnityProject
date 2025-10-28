using UnityEngine;
using UnityEngine.UI;

public class MiniGameController : MonoBehaviour
{
    public GameObject gameOverPanel;   // ���� �� ǥ���� UI
    public Text resultText;
    public float returnDelay = 2.5f;   // ���ͱ��� ��� �ð�

    public bool gameOver = false;     // ���� ���� Ȯ��
    private float elapsedTime = 0f;    // �ð� ������ ����


    public void EndMiniGame(bool success, int finalScore)
    {
        if (gameOver) return;
        gameOver = true;

        // ���� ����
        //ScoreManager.Instance.score = finalScore;
        //ScoreManager.Instance.SaveHighScore();
        PlayerPrefs.SetInt("LastScore", finalScore);
        PlayerPrefs.Save();

        // UI ���
        gameOverPanel.SetActive(true);
        resultText.text = success ? "����!" : "����!";

        // Ÿ�̸� �ʱ�ȭ
        elapsedTime = 0f;
    }

    void Update()
    {
        // ���� ���� �� �ð� ���� �� ���� �ð� �� �� ����
        if (gameOver)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= returnDelay)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("DD");
            }
        }
    }
}


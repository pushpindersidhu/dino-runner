using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicManager : MonoBehaviour
{
    public GameObject gameOverOverlay;
    public TextMeshProUGUI scoreObj;

    private bool gameOver;
    private int score;
    private int increment = 1;
    private float timer = 0;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverOverlay.SetActive(gameOver);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (gameOver) return;

        if (timer < 0.15f)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0;
        score += increment;
        scoreObj.text = $"Score: {score}";
    }
}

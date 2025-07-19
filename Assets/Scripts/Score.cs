using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score;
    private int increment = 1;
    private TextMeshProUGUI scoreObj;
    private float timer = 0;

    void Start()
    {
        scoreObj = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
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

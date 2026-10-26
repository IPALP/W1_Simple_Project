using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameUI: MonoBehaviour
{
    public TMP_Text ScoreText;
    public TMP_Text TimerText;
    public GameObject gameOverPanel;
    public TMP_Text finalScoreText;
    public float timeLeft = 60f;
    bool gameOver;
    void Start()
    {
        Time.timeScale = 1f;
        PickUp.score = 0;
        gameOverPanel.SetActive(false);
    }
    void Update()
    {
       if(gameOver) return;
       timeLeft -= Time.deltaTime;
       if(timeLeft <= 0)
        {
            timeLeft = 0;
            EndGame();
        } 
        TimerText.text = "Time: " + Mathf.CeilToInt(timeLeft);
        ScoreText.text = "Final score: " + PickUp.score;
       
    }
    void EndGame()
    {
        gameOver = true;
        finalScoreText.text = "Final score: "+ PickUp.score;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
} 




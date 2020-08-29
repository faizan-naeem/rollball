using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameStateManager : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverPanel;
    public Text winText;
    public Text scoreText;

    public static GameStateManager instance;
    void Awake()
    {
        if(instance == null)
            instance = this;
    }

    public void GameOver()
    {
        player.SetActive(false);
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    
    public void OnRestart(int level)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level" + level.ToString());
    }
    void Win()
    {
        Time.timeScale = 0;
        winText.gameObject.SetActive(true);
        SceneManager.LoadScene("MainMenu");
    }
    public void ManageScore(int score, int maxScore)
    {
        scoreText.text = score.ToString();
        if(score == maxScore)
            Win();
    } 
}

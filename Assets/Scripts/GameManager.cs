using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottamLeft;
    public static bool gameOver;
    public GameObject GameOverPanel;
    public static bool gameStarted;
    public GameObject startedPanel; //GetReady panel
    public GameObject score;
    public static int gameScore;
    void Awake()
    {
        bottamLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        gameOver = false;
    }
    void Start()
    {
        gameStarted = false;
    }
    public void GameHasStarted()
    {
        gameStarted= true;
        startedPanel.SetActive(false);
    }
    public void GameOver()
    {
        gameOver = true;
        gameScore = score.GetComponent<Score>().GetScore();
        GameOverPanel.SetActive(true);
        score.SetActive(false);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

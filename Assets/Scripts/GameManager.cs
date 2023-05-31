using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottamLeft;
    public static bool gameOver;
    public GameObject GameOverPanel;
    void Awake()
    {
        bottamLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }
    private void Start()
    {
        gameOver = false;
    }
    public void GameOver() { 
    
        gameOver= true;
        GameOverPanel.SetActive(true);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

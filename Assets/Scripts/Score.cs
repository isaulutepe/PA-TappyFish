using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int _score;
    private Text _scoreText;
    int highScore;
    public Text PanelScore;
    public Text PanelHighScore;
    public GameObject New;
    void Start()
    {
        _score = 0;
        _scoreText = GetComponent<Text>();
        _scoreText.text = _score.ToString();
        PanelScore.text = _score.ToString();

        highScore = PlayerPrefs.GetInt("highScore");//Veritabaný kullanmadan verileri yazýp alabildiðimiz bir Methottur.
        PanelHighScore.text = highScore.ToString();
    }

    public void Scored()
    {
        _score++;
        _scoreText.text = _score.ToString();
        PanelScore.text = _score.ToString();

        if (_score > highScore)
        {
            highScore = _score;
            PanelHighScore.text = highScore.ToString();
            PlayerPrefs.SetInt("highScore", highScore); //Veritabaný kullanamdan verileri yazýp alabildiðimiz bir Methottur.
            New.SetActive(true);
        }
    }
    public int GetScore()
    {
        return _score;
    }
}

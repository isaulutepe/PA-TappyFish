using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obstacle;

    private float _timer;
    public float maxTime;

    public float maxY;
    public float minY;
    float _randomY;

    void Update()
    {
        if (GameManager.gameOver == false && GameManager.gameStarted == true)
        {
            _timer += Time.deltaTime;
            if (_timer >= maxTime)
            {
                InstantiateObstacle();
                _timer = 0;
            }
        }
    }

    //Bir obje �retecek
    public void InstantiateObstacle()
    {
        _randomY = Random.Range(minY, maxY); //y ekseninde random konumlarda olu�mas� i�in.
        GameObject newObstacle = Instantiate(Obstacle); //Instantiate methodu nesne �retme i�lemi yapar.
        newObstacle.transform.position = new Vector2(transform.position.x, _randomY);
    }
}

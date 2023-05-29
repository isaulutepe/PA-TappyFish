using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obstacle;

    void Start()
    {
        InstantiateObstacle(); //Oyun ba�lad�p� andan itiberen verieln nesne �retilmeye ba�lanacak.
    }
    void Update()
    {

    }

    //Bir obje �retecek
    public void InstantiateObstacle()
    {
        GameObject newObstacle = Instantiate(Obstacle); //Instantiate methodu nesne �retme i�lemi yapar.
        newObstacle.transform.position = new Vector2(transform.position.x, transform.position.y);
    }
}

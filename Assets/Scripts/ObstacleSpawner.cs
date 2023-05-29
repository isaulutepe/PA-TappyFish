using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obstacle;

    void Start()
    {
        InstantiateObstacle(); //Oyun baþladýpý andan itiberen verieln nesne üretilmeye baþlanacak.
    }
    void Update()
    {

    }

    //Bir obje üretecek
    public void InstantiateObstacle()
    {
        GameObject newObstacle = Instantiate(Obstacle); //Instantiate methodu nesne üretme iþlemi yapar.
        newObstacle.transform.position = new Vector2(transform.position.x, transform.position.y);
    }
}

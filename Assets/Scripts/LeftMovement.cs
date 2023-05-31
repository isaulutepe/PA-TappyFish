using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    BoxCollider2D _box;
    float groundWidth;
    float obstacleWitdh;

    void Start()
    {
        if (gameObject.CompareTag("Ground"))
        {
            _box = GetComponent<BoxCollider2D>();
            groundWidth = _box.size.x;
        }
        else if (gameObject.CompareTag("Obstacle"))
        {
            obstacleWitdh = GameObject.FindGameObjectWithTag("Column").GetComponent<BoxCollider2D>().size.x;
        }
    }
    void Update()
    {

        if (GameManager.gameOver == false)
        {
            transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);
        }

        if (gameObject.CompareTag("Ground"))
        {
            if (transform.position.x <= -groundWidth)
            {
                transform.position = new Vector2(transform.position.x + 2 * groundWidth, transform.position.y);
            }
        }
        else if (gameObject.CompareTag("Obstacle"))
        {
            if (transform.position.x < GameManager.bottamLeft.x - obstacleWitdh)
            {
                Destroy(gameObject);
            }
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fish : MonoBehaviour
{

    Rigidbody2D _rb;
    [SerializeField] private float _speed;

    //Balýgýn aþaðý yukarý rotasyonunun deðiþmesi için.
    int angle;
    int maxAngel = 20;
    int minAngle = -60;

    public Score score;

    public GameManager manager;
    public ObstacleSpawner obstacleSpawner;
    public Sprite fishDied;
    SpriteRenderer _sp;
    Animator _anim;

    bool touchedGround;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
        _sp = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        FishSwim();
    }
    private void FixedUpdate()
    {
        FishRotation();
    }
    void FishSwim()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.gameOver == false)
        {
            if (GameManager.gameStarted == false)
            {
                _rb.gravityScale = 5f;
                _rb.velocity = Vector3.zero;
                _rb.velocity = new Vector2(_rb.velocity.x, _speed);
                obstacleSpawner.InstantiateObstacle();
                manager.GameHasStarted();
            }
            else
            {
                _rb.velocity = Vector2.zero;
                _rb.velocity = new Vector2(_rb.velocity.x, _speed);
            }
        }
    }
    void FishRotation()
    {
        if (_rb.velocity.y > 0)
        {
            if (angle <= maxAngel)
                angle = angle + 4;
        }
        else if (_rb.velocity.y < -2.5f)
        {
            if (angle > minAngle)
            {
                angle -= 2;
            }
        }
        if (touchedGround == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            score.Scored();
        }
        else if (collision.CompareTag("Column"))
        {
            manager.GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (GameManager.gameOver == false)
            {
                manager.GameOver();
                GameOver();
            }
        }
    }
    void GameOver()
    {
        touchedGround = true;
        _sp.sprite = fishDied;
        _anim.enabled = false;
        transform.rotation = Quaternion.Euler(0, 0, -90);
    }
}

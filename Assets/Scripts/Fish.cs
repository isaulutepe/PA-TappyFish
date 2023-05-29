using System.Collections;
using System.Collections.Generic;
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
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _speed);

        }
        //AÇI ÝÇÝN ÝÞLEMLER.
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
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            score.Scored();
        }
    }
}

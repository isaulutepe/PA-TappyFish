using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottamLeft;
    public static bool gameOver;
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
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

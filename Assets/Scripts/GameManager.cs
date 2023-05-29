using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottamLeft;
    void Awake()
    {
        bottamLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

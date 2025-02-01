using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingArrows : MonoBehaviour
{
    [SerializeField ] int speed = 1;
    Vector3 movementDirection = new Vector3(0, -0.5f, -1);
    enum Arrows
    {
        W , A , S , D
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        MoveDown();
    }
    public void MoveDown()
    {
        gameObject.transform.position = gameObject.transform.position + movementDirection * Time.deltaTime * speed;
    }
}

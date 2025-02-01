using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ref : last comp sci class
public class TTL : MonoBehaviour
{
    [SerializeField] float timeToLive = 3;
    float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (Time.time > startTime + timeToLive  ) 
        {
            Destroy(gameObject);
        }
    }
}

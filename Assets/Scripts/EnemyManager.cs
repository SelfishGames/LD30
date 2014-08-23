﻿using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed;

    private int currentArea = 0;

    void Start()
    {
        transform.position = patrolPoints[0].position;
        currentArea = 0;

    }

    void Update()
    {
        
        if(transform.position == patrolPoints[currentArea].position)
        {
            currentArea++;
        }

        if (currentArea >= patrolPoints.Length)
        {
            currentArea = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentArea].position, speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            col.gameObject.SetActive(false);   
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private EnemyController _enemyHealth;
    public float score;
    
    void Start()
    {
       // _enemyHealth = gameObject.AddComponent<EnemyController>();
        _enemyHealth = FindObjectOfType<EnemyController>();
    }//Start

    
    void Update()
    {
        print(_enemyHealth._enemyLife);
    }//Update

}//Class

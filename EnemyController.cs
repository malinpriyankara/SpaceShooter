using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.0f;
    public float _enemyLife=6;
    [SerializeField]
    private GameObject _enemyToSpawn;
    [SerializeField]
    private GameObject _singleLaser;
    [SerializeField]
    private GameObject _tripleLaser;
    void Start()
    {
        
    }//Start

    
    void Update()
    {
        EnemyMovemets();

    }//Update

    private void EnemyMovemets()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * _speed);
    }//Enemy Movements
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if (collision.gameObject.CompareTag("SingleShot")) {
            _enemyLife -= 1;
            
        }
        if (collision.gameObject.CompareTag("TripleShot")) { 
            _enemyLife -= 3;
            
        }
        //print(_enemyLife);
    }
}//Class

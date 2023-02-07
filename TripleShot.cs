using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShot : MonoBehaviour
{
    [SerializeField]
    private float _tripleShotSpeed=1f;
    [SerializeField]
    private GameObject _tripleShot;
    private  PlayerController _playerController;
    void Start()
    {
        
        
    }//Start

    
    void Update()
    {
        TripleShotMove();
    }//Update
    void TripleShotMove()
    {
        if (_playerController._tripleLaserOn)
        {
            transform.Translate(Vector3.down * _tripleShotSpeed * Time.deltaTime);
            if (_tripleShot.transform.position.y <= -12f)
            {
                Destroy(_tripleShot);
            }
        }
    }//TripleShotMove
   
}//Class

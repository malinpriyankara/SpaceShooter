using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _keySpeed = 1.0f;
    [SerializeField] private float _rotationSpeed = 5.0f;
    [SerializeField] private float _mouseSpeed = 100.0f;
    [SerializeField] private GameObject _laserBeam;
    [SerializeField] private GameObject _tripleLaserBeam;
    [SerializeField] private float _tripleShotTimer = 10f;
    [SerializeField] private GameObject _tripleShot;
    private GameObject _tShot;
    private float _horizontalInput, _verticalInput;
    private float _mouseX, _mouseY;
    private Vector3 _playerDirection;
    private Vector3 _playerPos;
    public bool _tripleLaserOn = false;

    private void Start()
    {
        //transform.position.z = 0f;  
    }//Start

    
    private void Update()

    {
        //moving object by position for both direction from mouse + keys

        PlayerMove();
        LaserBeam();
        TripleShot();
        
    }//Update

    private void PlayerMove()
    { 
       if (transform.position.y <= 0.0f && transform.position.y >= -5f && transform.position.x <= 12.5f && transform.position.x >= -12.5f)
        {
            transform.Translate(Vector3.right * _keySpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
            transform.Translate(Vector3.up * _keySpeed * Time.deltaTime * Input.GetAxis("Vertical"));
            //print("If executed");
            /*_playerPos.x = transform.position.x;
            if (_playerPos.x <= -12.5f)
            {
                _playerPos.x = 12.5f;
            print("If executed");
            }*/
        }
    }//PlayerMove
    private void LaserBeam()
    {
        if (_tripleLaserOn==true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(_tripleLaserBeam, transform.position + new Vector3(1.25f, 1.5f, 0f), Quaternion.identity);
            }
        }
        if(_tripleLaserOn==false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(_laserBeam, transform.position + new Vector3(0.05f, 2f, 0f), Quaternion.identity);
            }
        }

    }//LaserBeeam
    private void TripleShot()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            _tShot = Instantiate(_tripleShot, transform.position + new Vector3(Random.Range(-10f, 10f), 12f, 0f),Quaternion.identity);
        }
        
    }//TripleShot
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TripleShot") )
        {
            _tripleLaserOn = true;
             print("Collision Occured");
             Destroy(_tShot);
            
            
        }
    }
}//Class

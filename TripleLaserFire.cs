using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleLaserFire : MonoBehaviour
{
    [SerializeField] private GameObject _tripleLaserBeam;
    [SerializeField] private float _laserSpeed = 50f;
    [SerializeField] private GameObject _enemy;
    private static GameManager _gameMgr;

    void Start()
    {
        _gameMgr = FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        Lasershoot();
    }//Update
    private void Lasershoot()
    {
        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);
        if ( _tripleLaserBeam.transform.position.y >= 6f)
        {
            
            Destroy(_tripleLaserBeam);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(_tripleLaserBeam);
            Destroy(_enemy);
            _gameMgr.score++;
        }
    }
}//class

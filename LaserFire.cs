using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFire : MonoBehaviour
{
    [SerializeField] private float _laserSpeed = 50f;
    [SerializeField] private GameObject _laserBeam;
    [SerializeField] private GameObject _enemy;
    public bool newObject;
    
    void Start()
    {
       
    }//start

    
    void Update()
    {
        Lasershoot();
    }//update

    private void Lasershoot()
    {
        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);
        if (_laserBeam.transform.position.y >= 6f )
        {
            Destroy(_laserBeam);
            Destroy(_enemy);
        }
    }
}//class


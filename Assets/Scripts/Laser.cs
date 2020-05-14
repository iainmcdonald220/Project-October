using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour

    
{

    public float _laserSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // laser shoots - movement forward from player
        transform.Translate(Vector3.forward * _laserSpeed * Time.deltaTime);


    }
}

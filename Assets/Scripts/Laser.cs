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

        //shoots the laser forward from player's current facing position
        transform.Translate(Vector3.forward * _laserSpeed * Time.deltaTime);

        //destroys laser prefab if it passes outside of game view
        if (transform.position.z > 15.0f)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.x > 15.0f)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.x < -15.0f)
        {
            Destroy(this.gameObject);
        }


    }
}

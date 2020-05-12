using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update


    public CharacterController CharCtrl;

    private float smooth = 5.0f;
    private float tiltAngle = 60.0f;


    void Start()
    {
       // CharCtrl = this.GetComponent<CharacterController>();
        transform.position = new Vector3(0, 0, -4);

    }

    // Update is called once per frame
    void Update()

    {

        transform.position = new Vector3(0, 0, -4);

        float tiltAroundY = Input.GetAxisRaw("Horizontal") * tiltAngle;
        //float tiltAroundZ = Input.GetAxisRaw("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(0, tiltAroundY, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

        // Vector3 NextDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        // if (NextDir != Vector3.zero)
        //     transform.rotation = Quaternion.LookRotation(NextDir);
        // CharCtrl.Move(NextDir / 8);

        if (transform.position.x > 0.0f)
        {
            transform.position = new Vector3(0, transform.position.y, -4);
        }
        else if (transform.position.x < 0.0f)
        {
            transform.position = new Vector3(0, transform.position.y, -4);
        }

        if (transform.position.z > 0.0f)
        {
            transform.position = new Vector3(0, transform.position.y, -4);
        }
        else if (transform.position.z < 0.0f)
        {
            transform.position = new Vector3(0, transform.position.y, -4);
        }


    }
}

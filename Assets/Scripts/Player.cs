using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update


    public CharacterController CharCtrl;


    public GameObject _redLaser;
    public GameObject _blueLaser;
    public GameObject _yellowLaser;    
    public GameObject _greenLaser;

    private float smooth = 5.0f;
    private float tiltAngle = 90.0f;


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


        //player position restriction (cannot actually move)

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


        //shooting - different buttons on the pad fires different coloured lasers
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Debug.Log("Button0");
            Instantiate(_greenLaser, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            Debug.Log("Button1");
            Instantiate(_redLaser, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            Debug.Log("Button2");
            Instantiate(_blueLaser, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            Debug.Log("Button3");
            Instantiate(_yellowLaser, transform.position, transform.rotation);
        }



    }
}

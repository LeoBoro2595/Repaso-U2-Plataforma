using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float zSpeed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
        //transform.position += new Vector3(0, 0, zSpeed);
        transform.Translate(0, 0, 0.1f);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.1f);
        }

        else if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0.1f, 0);
        }

        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(0.1f, 0, 0);
        }

        else if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0, -0.1f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.eularAngles += new Vector3(0, rotationSpeed, 0);
            transform.Rotate(0, 1, 0);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            //transform.eularAngles += new Vector3(0, rotationSpeed, 0);
            transform.Rotate(0, -1f, 0);
        }
    }
}

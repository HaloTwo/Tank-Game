using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{

    public float speed = 20.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -60f, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 60f, 0) * Time.deltaTime);
        }
    }
}

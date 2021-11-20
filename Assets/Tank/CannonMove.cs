using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMove : MonoBehaviour
{
    public float bullet_power = 10000.0f;
    public GameObject barrel;
    public GameObject bullet;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(new Vector3(-20f, 0, 0) * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(new Vector3(20f, 0, 0) * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject spawn_point = GameObject.Find("sp_bullet");
            GameObject prefab_bullet = Instantiate(bullet, spawn_point.transform.position, spawn_point.transform.rotation);
            prefab_bullet.GetComponent<Rigidbody>().AddForce(-barrel.transform.up * bullet_power);
        }
    }
}

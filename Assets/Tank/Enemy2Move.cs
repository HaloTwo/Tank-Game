using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Move : MonoBehaviour
{
    int life = 2;
    float speed = 20.0f;
    public AudioSource crush;


    void Start()
    {
        crush = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (transform.localPosition.z < 550.0)
       {
           speed = -20;
        }
        else if (transform.localPosition.z > 850.0)
        {
            speed = 20;
        }

        transform.Translate(Vector3.back * 2.0f * Time.deltaTime * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "bullet(Clone)")
        {
            crush.Play();
            life--;
            if (life <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

}

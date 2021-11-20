using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bulletaction : MonoBehaviour
{

    public GameObject restartbtn;
    public GameObject explosion_effect;


    public void Start()
    {

    }
    private void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Instantiate(explosion_effect, this.transform.position, this.transform.rotation);
            GameManeger.score -= 1;
            if(GameManeger.score <= 0)
            {
                SceneManager.LoadScene("Victory");
            }
        }
        Destroy(this.gameObject);
    }
}

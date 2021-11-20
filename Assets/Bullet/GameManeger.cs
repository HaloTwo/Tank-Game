using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour
{
    Text text;
    public static int score = 10;

    private void Start()
    {
        text = GetComponent<Text>();
    }
    private void Update()
    {
        text.text = "Hit : " + score.ToString();
    }
}
   

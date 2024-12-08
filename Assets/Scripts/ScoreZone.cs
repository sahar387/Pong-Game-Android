using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreZone : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private int score;
    void Start()
    {
        score = 0; 
    }


    void OneCollisionEnter2D(Collision2D col)
    {
        score++;
        scoreText.text = score.ToString();
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    int life =2 ;
    int adscoins;
    public static GameManager inst;

    [SerializeField] Text scoreText;
    [SerializeField] Text lifeText;

    [SerializeField] PlayerMovement playerMovement;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        // Increase the player's speed
       
    }



    public void IncrementAdsPoints()
    {
        adscoins++;
        scoreText.text = "adspoints: " + adscoins;
        // Increase the player's speed

    }
    public void DecrementLife()
    {
        if (life > 0)
        {
            life = life - 1;
            lifeText.text = "LIFE: " +life;
        }
        else
            playerMovement.Die();
        
    }


    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {

    }

    private void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerManager : MonoBehaviour
{


    public static bool  gameOver;
    public GameObject gameOverPanel;
    public static bool isGameStarted;
    public GameObject startingText;
    public static int numberofcoins;
    public Text cointext;
    public Text aftercointext;
    public Text highscoreText;

    public static PlayerManager inst;


    public static int life;
    [SerializeField] Text lifeText;

    [SerializeField] MovementPlayer playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberofcoins = 0;

    }





    public void DecrementLife()
    {
        if (life > 0)
        {
            life = life -1;
            lifeText.text = "LIFE: " + life;
        }
         if(life==0)
        {
            //PlayerPrefs.SetInt("HighScore", numberofcoins);
            Time.timeScale = 0;
            if (PlayerPrefs.GetInt("HighScore") < numberofcoins)
            {
                PlayerPrefs.SetInt("HighScore", numberofcoins);
            }
            
            aftercointext.text = "Coins:" + numberofcoins;
            gameOverPanel.SetActive(true);
            highscoreText.text = "HighScore:" + PlayerPrefs.GetInt("HighScore").ToString();
        }
         
    }


    private void Awake()
    {
        inst = this;
    }

    // Update is called once per frame
    void Update()
    {
       
        cointext.text = "Coins:" + numberofcoins;
        if (SwipeMananger.tap)
        {
            isGameStarted = true;
            Destroy(startingText);
        }
    }
}

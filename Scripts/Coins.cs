using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
       

        // Check that the object we collided with is the player
        if (other.gameObject.name != "Player")
        {
            PlayerManager.numberofcoins += 1;
            Destroy(gameObject);
            Debug.Log("Coins:" + PlayerManager.numberofcoins);
            GameControlerScript.moneyAmount += 1;
            GameManager.inst.IncrementScore();

            // Destroy this coin object
           // Destroy(gameObject);

        }

        // Add to the player's score
        //GameManager.inst.IncrementScore();
        PlayerManager.numberofcoins += 1;
        Debug.Log("Coins:" + PlayerManager.numberofcoins);
        GameControlerScript.moneyAmount += 1;
        GameManager.inst.IncrementScore();

        // Destroy this coin object
        Destroy(gameObject);
    }

    private void Start()
    {

    }

    private void Update()
    {
        transform.Rotate(turnSpeed * Time.deltaTime, 0, 0);
    }
}

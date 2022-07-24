using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinnew : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerManager.numberofcoins += 1;
            Debug.Log("Coins:" + PlayerManager.numberofcoins);
            GameControlerScript.moneyAmount += 1;
            Destroy(gameObject);
        }
    }
}

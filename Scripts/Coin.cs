using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	void OnTriggerEnter(Collider col)
	{
		GameControlerScript.moneyAmount += 1;
		Destroy(gameObject);
	}
}


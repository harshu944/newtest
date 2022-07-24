using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControlerScript : MonoBehaviour
{
	public Text moneyText;
	public GameObject myobject;
	

	public static int moneyAmount;
	
	int isRifleSold;
	int isRifleSold2;
	public GameObject rifle;
	public GameObject rifle2;
	public Button buyButton2;

	// Use this for initialization
	void Start()
	{
		moneyAmount = PlayerPrefs.GetInt("HighScore");
		
		isRifleSold = PlayerPrefs.GetInt("IsRifleSold");

		if (isRifleSold == 1)
		{

			//myobject.SetActive(false);
			//rifle.SetActive(true);


		}
		else
		{
			//myobject.SetActive(true);

			//rifle.SetActive(false);

		}




	}

	// Update is called once per frame
	void Update()
	{
		moneyText.text = "Money: " + moneyAmount.ToString() + "$";

		
	}
	
	public void gotoShop()
	{
		PlayerPrefs.SetInt("HighScore", moneyAmount);
		

		SceneManager.LoadScene("Store");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlerScript : MonoBehaviour
{
	int moneyAmount;
	int isRifleSold;
	
	public Text adsText;
	public static int adsAmount;
	int isRifleSold1;
	int isRifleSold2;
	int isRifleSold3;
	int isRifleSold4;



	public Text moneyAmountText;
	public Text riflePrice;
	public Text riflePrice1;

	public Text riflePrice2;
	
	public Text riflePrice3;
	public Text riflePrice4;


	public Button buyButton;
	public Button buyButton1;

	public Button buyButton2;
	public Button buyButton3;
	public Button AdsButton;

	
	


	// Use this for initialization
	void Start()
	{
		moneyAmount = PlayerPrefs.GetInt("HighScore");
		adsAmount= PlayerPrefs.GetInt("AdsAmount");


	}

	// Update is called once per frame
	void Update()
	{

		moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";
		adsText.text =  adsAmount.ToString() + "$";

		isRifleSold = PlayerPrefs.GetInt("IsRifleSold");
		isRifleSold1 = PlayerPrefs.GetInt("IsRifleSold1");
		isRifleSold2 = PlayerPrefs.GetInt("IsRifleSold2");
		isRifleSold3 = PlayerPrefs.GetInt("IsRifleSold3");
		//ads part reward
		isRifleSold4 = PlayerPrefs.GetInt("IsRifleSold4");

		if (moneyAmount >= 5 && isRifleSold == 0)
			buyButton.interactable = true;
		else
		{
			buyButton.interactable = false;
		}
		



		if (moneyAmount >= 6 && isRifleSold1 == 0)
			buyButton1.interactable = true;
		else
			buyButton1.interactable = false;





		//isRifleSold2 = PlayerPrefs.GetInt("IsRifleSold2");
		if (moneyAmount >= 7 && isRifleSold2 == 0)
			buyButton2.interactable = true;
		else
			buyButton2.interactable = false;




		//isRifleSold3 = PlayerPrefs.GetInt("IsRifleSold3");
		if (moneyAmount >= 8 && isRifleSold3 == 0)
			buyButton3.interactable = true;
		else
			buyButton3.interactable = false;




		if (adsAmount >= 8 && isRifleSold4 == 0)
			AdsButton.interactable = true;
		else
			AdsButton.interactable = false;
































	}

	public void buyRifle()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("IsRifleSold", 1);
		riflePrice.text = "Sold!";
		buyButton.gameObject.SetActive(false);
	}

	public void buyRifle1()
	{
		moneyAmount -= 6;
		PlayerPrefs.SetInt("IsRifleSold1", 1);
		riflePrice1.text = "Sold!";
		buyButton1.gameObject.SetActive(false);
	}





	public void buyRifle2()
	{
		moneyAmount -= 7;
		PlayerPrefs.SetInt("IsRifleSold2", 1);
		riflePrice2.text = "Sold!";
		buyButton2.gameObject.SetActive(false);
	}

	public void buyRifle3()
	{
		moneyAmount -= 8;
		PlayerPrefs.SetInt("IsRifleSold3", 1);
		riflePrice3.text = "Sold!";
		buyButton3.gameObject.SetActive(false);
	}




	public void buyRifle4()
	{
		adsAmount -= 8;
		PlayerPrefs.SetInt("IsRifleSold4", 1);
		riflePrice4.text = "Sold!";
		AdsButton.gameObject.SetActive(false);
	}







	public void exitShop()
	{
		PlayerPrefs.SetInt("HighScore", moneyAmount);
		PlayerPrefs.SetInt("AdsAmount", adsAmount);



		SceneManager.LoadScene("MainMenu");
	}

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		adsAmount = 0;
		buyButton.gameObject.SetActive(true);
		buyButton2.gameObject.SetActive(true);

		riflePrice.text = "Price: 5$";
		riflePrice1.text = "Price: 6$";
		riflePrice2.text = "Price: 7$";
		riflePrice3.text = "Price: 8$";
		riflePrice3.text = "Price: 8$";





		PlayerPrefs.DeleteAll();
	}

}

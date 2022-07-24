using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonActive3 : MonoBehaviour
{


	int isRifleSold1;



	public Button buyButton2;

	void Start()
	{
		isRifleSold1 = PlayerPrefs.GetInt("IsRifleSold1");



		if (isRifleSold1 == 1)
		{

			buyButton2.interactable = true;


		}
		else
		{
			buyButton2.interactable = false;

		}
	}
}
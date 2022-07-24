using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonActive4 : MonoBehaviour
{
	int isRifleSold1;



	public Button buyButton2;

	void Start()
	{
		isRifleSold1 = PlayerPrefs.GetInt("IsRifleSold2");



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

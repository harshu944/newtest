using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActive : MonoBehaviour
{
    int isRifleSold1;
	


	public Button buyButton1;

	void Start()
	{
		isRifleSold1 = PlayerPrefs.GetInt("IsRifleSold");



		if (isRifleSold1 == 1)
		{

			buyButton1.interactable = true;


		}
		else
		{
			buyButton1.interactable = false;

		}

	}

}

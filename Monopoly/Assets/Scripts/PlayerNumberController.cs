using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNumberController : MonoBehaviour {
	public bool isChosen = false;
	public int number = 0;
	public Text playersNumber;

	public void ShowDialog ()
	{
		isChosen = false;
		this.gameObject.SetActive(true);
	}

	public void Accept ()
	{
		number = int.Parse (playersNumber.text);
		isChosen = true;
		this.gameObject.SetActive (false);
	}

}

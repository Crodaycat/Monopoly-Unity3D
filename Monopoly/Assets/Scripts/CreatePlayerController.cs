using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayerController : MonoBehaviour {
	public bool isChosen = false;
	public Text informationText;
	public InputField playerNameInput;
	public string playerName;

	public void ShowDialog(int playerNumb)
	{
		playerNameInput.text = "";
		isChosen = false;
		informationText.text = "Ingrese el nombre para el jugador #" + playerNumb.ToString() + ":";
		this.gameObject.SetActive (true);
	}

	public void Accept ()
	{
		playerName = playerNameInput.text;
		isChosen = true;
		this.gameObject.SetActive (false);
	}
}

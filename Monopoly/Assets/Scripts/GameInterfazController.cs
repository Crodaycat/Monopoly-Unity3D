using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInterfazController : MonoBehaviour {
	public Text playerTurnText;
	public Text playerMoneyText;
	public Text dice1Text;
	public Text dice2Text;
	public Button throwDiceButton;

	public GameObject gameInterfazPanel;
	public GameObject throwDiceInterfaz;

	public bool hasThrowDices = false;

	public int dice1;
	public int dice2;

	public void ShowGameInterface()
	{
		gameInterfazPanel.SetActive (true);
	}

	public void ChangePlayerTurn (Player player)
	{
		playerTurnText.text = "Turno del jugador: " + player.playerName;
	}

	public void ShowDiceThrower (Player player)
	{
		UpdatePlayerMoney (player);
		ChangePlayerTurn (player);
		throwDiceButton.interactable = true;
		hasThrowDices = false;
		throwDiceInterfaz.SetActive (true);
	}

	public void HideDiceThrower ()
	{
		hasThrowDices = false;
		throwDiceInterfaz.SetActive (false);
	}

	public void ThrowDices ()
	{
		throwDiceButton.interactable = false;

		dice1 = Random.Range (1, 7);
		dice2 = Random.Range (1, 7);

		dice1Text.text = dice1.ToString();
		dice2Text.text = dice2.ToString();

		hasThrowDices = true;
	}

	public void UpdatePlayerMoney (Player player)
	{
		playerMoneyText.text = "Dinero: $" + player.money.ToString ();
	}
}

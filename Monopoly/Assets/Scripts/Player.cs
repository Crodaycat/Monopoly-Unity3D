using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{

	public string playerName;
	public int square = 0;
	public int money;
	public bool isInPrison = false;
	public int turnsToLose = 0;

	public bool isMoving = false;

	public IEnumerator Walk (int move)
	{
		isMoving = true;
		while (move > 0) 
		{
			move--;
			square = (square + 1) % GameController.singleton.squares.Count;
			this.gameObject.transform.position = GameController.singleton.squares[square].transform.position;
			yield return new WaitForSeconds (0.5f);
		}
		isMoving = false;
	}

	public void LoseTurn ()
	{
		turnsToLose--;
		if (turnsToLose == 0)
			isInPrison = false;
	}
}

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

	public void Walk ()
	{
		print ("Programar metodo para que el juegador camine");
	}
}

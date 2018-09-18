using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jail : Square 
{
	public enum JailType
	{
		Visiting,
		GoToJail
	}

	public JailType jailType;

	public void GoToJail (Player player)
	{
		print ("Programar metodo para ir a la cárcel");
	}
}

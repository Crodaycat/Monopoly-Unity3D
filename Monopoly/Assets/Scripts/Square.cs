using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour 
{
	public enum SquareType 
	{
		Property,
		CommununityChest,
		Tax,
		Chance,
		Jail,
		FreeParking
	};

	public SquareType squareType;

}

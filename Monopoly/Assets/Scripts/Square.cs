using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour 
{
	public enum SquareType 
	{
		Property,
		CommunalChest,
		Tax,
		Chance,
		Jail,
		FreeParking
	};

	public SquareType squareType;

}

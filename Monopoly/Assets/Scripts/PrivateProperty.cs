using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivateProperty : Property
{
	public enum Neighborhood
	{
		Rojo,
		Amarillo,
		Verde,
		Azul,
		Cafe,
		Celeste,
		Magenta,
		Naranja
	}

	public Neighborhood neighborhood;
	public List<Building> buildings;
}

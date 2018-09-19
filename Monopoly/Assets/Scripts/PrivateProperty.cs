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
	};

	public int rent;
	public Neighborhood neighborhood;
	public List<Building> buildings;

	public override int GetRent (Player player)
	{
		print ("Desarrollar el método que calcule la renta de una propiedad privada");
		PropertyCard card = (PropertyCard)this.gameCard;
		return card.rent;
	}
}

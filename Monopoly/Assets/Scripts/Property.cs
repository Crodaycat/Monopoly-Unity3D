using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : Square 
{
	public string propertyName;
	public int propertyValue;
	public Player owner;
	public int rent;
	public GameCard gameCard;
	public int mortgage; // Lo que el banco te paga por hipotecar la propiedad

	public bool IsOwner (Player player) 
	{
		return this.owner.playerName == player.playerName;
	}

	public int GetRent ()
	{
		return rent;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : Square 
{
	public int propertyValue;
	public Player owner;
	public int rent;
	public GameCard gameCard;
	public int mortgage;

	public bool IsOwner (Player player) 
	{
		return this.owner.playerName == player.playerName;
	}

	public int getRent ()
	{
		return rent;
	}
}

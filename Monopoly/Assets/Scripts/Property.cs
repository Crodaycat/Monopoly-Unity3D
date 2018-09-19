using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : Square 
{
	public string propertyName;
	public int propertyValue;
	public Player owner;
	public GameCard gameCard;
	

	public bool IsOwner (Player player) 
	{
		return this.owner.playerName == player.playerName;
	}

	public virtual int GetRent (Player player)
	{
		return 0;
	}
}

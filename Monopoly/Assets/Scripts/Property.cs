using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : Square 
{
	public enum PropertyType
	{
		PrivateProperty,
		Service,
		Station
	}

	public PropertyType propertyType;
	public string propertyName;
	public int propertyValue;
	public Player owner;
	public GameCard gameCard;
	

	public bool IsOwner (Player player) 
	{
		if (this.owner != null)
			return this.owner.playerName == player.playerName;

		return false;
	}

	public virtual int GetRent (Player player)
	{
		return 0;
	}
}

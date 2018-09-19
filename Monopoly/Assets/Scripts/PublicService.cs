using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicService : Property {

	public override int GetRent (Player player)
	{
        CommunityCard card = (CommunityCard)this.gameCard;
        if (this.IsOwner(player))
		{
			return 0;
		} else if (GameController.singleton.water.owner == GameController.singleton.electricity.owner) 
		{
			print ("Arreglar para que retorne con el metodo de los datos");
			return (3 * 10);
		} else if (GameController.singleton.water.owner != GameController.singleton.electricity.owner) 
		{
			print ("Arreglar para que retorne con el metodo de los datos");
			return (3 * 4);
		}
		return 0;
	}
}

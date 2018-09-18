using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : Property
{
    public int rent;
    public override int GetRent(Player player)
    {
        if (this.IsOwner(player))
        {
            return 0;
        }
        else
        {
            int count = GameController.singleton.stations.FindAll(x => x.IsOwner(this.owner)).Count;
            switch (count)
            {
                case 1:
                    if(count == 2) return 25;
                    break;
                case 2:
                    if(count == 3) return 50;
                    break;
                case 3:
                    if (count == 4) return 100;
                    break;
                case 4:
                    if(count == 1) return 200;
                    break;
            }
        }
        return 0;
    }
}
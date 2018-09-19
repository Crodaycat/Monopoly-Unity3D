using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tax : Square {
    public enum TaxType
    {
        LuxuryTax,
        IncomeTax
    };

    public TaxType taxType;
    public int taxValue;
	public bool isCalculated = false;
	public int calculatedTax;
    
	public IEnumerator GetIncomeTax (Player player)
    {
		IncomeTaxController.singleton.ShowDialog ();
		return new WaitUntil (() => IncomeTaxController.singleton.chosen);
		if (IncomeTaxController.singleton != null && IncomeTaxController.singleton.pay)
			calculatedTax = 200;
		else if (IncomeTaxController.singleton != null)
			calculatedTax = (int)(player.money * 0.1);
		else
			calculatedTax = 0;
			
		isCalculated = true;
    }

	public int GetLuxuryTax ()
	{
		return 75;
	}
}

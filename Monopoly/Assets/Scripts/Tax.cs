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
    
    public int GetIncomeTax(Player player)
    {
        taxValue = TaxType
        return taxValue;
    }
}

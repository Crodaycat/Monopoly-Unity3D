using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncomeTaxController : MonoBehaviour {

	public static IncomeTaxController singleton;

	public bool chosen = false;
	public bool pay = false; // Si es falso: eligio pagar el 10% de lo contrario paga 200

	public IncomeTaxController ()
	{
		if (singleton == null)
			singleton = this;
		else if (singleton != this)
			Destroy (this);
	}

	public void ShowDialog ()
	{
		chosen = false;
		this.gameObject.SetActive (true);
	}

	public void PayTenPercent ()
	{
		chosen = true;
		pay = false;
	}

	public void Pay () 
	{
		chosen = true;
		pay = true;
	}

}

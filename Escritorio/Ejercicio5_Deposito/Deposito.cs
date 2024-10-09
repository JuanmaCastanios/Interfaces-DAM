using System;
using System.Configuration;

public class Deposito
{
	public event EventHandler Cantidad_Changed; // Cada vez que cambia la cantidad de agua 
	public event EventHandler DepositoVacio; //Cuando la cantidad sea 0
	private int cantidad;
	public Deposito()
	{
		Cantidad = 10;

	}

    public int CantidadEjemplo1 { get; set; } //Propiedad autoimplementadas

	private int cantidadEjemplo2;

	public int CantidadEjemplo2
	{
		get { return cantidadEjemplo2; }
		set { cantidadEjemplo2 = value; }
	}


	

	public int Cantidad
	{
		get { return cantidad; }
		set
		{
			cantidad = value; 
			Cantidad_Changed?.Invoke(this, EventArgs.Empty);
			if(cantidad == 0)
			{
				DepositoVacio?.Invoke(this, EventArgs.Empty);
			}
		}
	}

	public void Llenar(int valor)
	{
		Cantidad = valor;
	}


}

using System;
using System.Security.Cryptography.X509Certificates;

public class Caldera
{
	public event EventHandler CalderaMaximo;
	public event EventHandler ActualizarCaldera;

	public Caldera()
	{
		valorCaldera = 0;
	}

	private int valorCaldera;

	public int ValorCaldera
    {
		get
		{
			return valorCaldera;
		}
		set
		{ 
			if(value >= 0 && value < 99)
			valorCaldera = value;
			else if (value == 99)
			{
				CalderaMaximo?.Invoke(this, EventArgs.Empty);
			}
		}
	}


	private string estado;

	public string Estado
	{
		get
		{
			return estado;
		}
		set
		{
			if(valorCaldera < 60)
			{
				estado = "Verde";
			} 
			else if (valorCaldera >= 60 && valorCaldera <80)
			{
                estado = "Amarillo";
            }
			else
			{
				estado = "Rojo";
			}
		}
	}




}

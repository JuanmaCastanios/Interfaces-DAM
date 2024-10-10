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
			
				valorCaldera = value;
			if (value == 99)
				CalderaMaximo?.Invoke(this, EventArgs.Empty);
		}
	}


	private string estado;


	public string Estado
    {
		get { return estado; }
		set
		{
			estado = value;
            if (valorCaldera == 59 && estado == "Alerta\t")
            {
                estado = "Correcto";
                ActualizarCaldera?.Invoke(this, EventArgs.Empty);
            }
            else if ((valorCaldera == 60 && estado == "Correcto") || (valorCaldera == 79 && estado == "Peligro"))
            {
                estado = "Alerta\t";
                ActualizarCaldera?.Invoke(this, EventArgs.Empty);
            }
            else if(valorCaldera == 80 && estado == "Alerta\t")
            {
                estado = "Peligro";
                ActualizarCaldera?.Invoke(this, EventArgs.Empty);
            }
        }
	}


	private DateTime tiempo;

    public int Tiempo { get; set; }
    public string mostrarEstado()
	{
		string info = "";

        tiempo = DateTime.Now;

		info = "\t" + estado + "\t" + tiempo.ToString("HH:mm:ss");

		return info;
	}

}

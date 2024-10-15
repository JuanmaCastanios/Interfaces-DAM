using System;

public class Cajetin
{
	public Cajetin()
	{
	}

    private double[] monedasValidas = { 2.0, 1.0, 0.5, 0.2, 0.1 };

	public event EventHandler TotalChange;
    public event EventHandler MonedaNoValida;

    private double total;
	public double Total
	{
		get { return total; }
		set { total = value; }
	}


	private double vuelta;
	public double Vuelta
    {
		get { return vuelta; }
		set { vuelta = value; }
	}

	public void Acumular(double moneda)
	{

	}

    public bool Dispensar()
	{
		return false;
	}

    public double Devolver()
	{
		return 0.0;
	}

	public void Iniciar()
	{
		total = 0;
	}

}

using System;

public class Cajetin
{
    public Cajetin()
    {
    }

    private double[] monedasValidas = { 2.0, 1.0, 0.5, 0.2 };

    public event EventHandler TotalChange;
    public event EventHandler MonedaNoValida;

    private double total = 0.0;
<<<<<<< HEAD
=======

>>>>>>> origin/main
	public double Total
	{
		get { return total; }
		set { total = value; }
	}

<<<<<<< HEAD

	private double vuelta;
	public double Vuelta
    {
        get { return total; }
        set { total = value; }
    }

=======
    private double vuelta;
    public double Vuelta
    {
        get { return vuelta; }
        set { vuelta = value; }
    }

    public bool Dispensar(Producto p)
    {
        if (total >= p.Precio)
        {
            return true;
        }
        return false;
    }
>>>>>>> origin/main

	public void Acumular(double moneda)
	{
		if (monedasValidas.Contains(moneda))
		{
			total += moneda;
            TotalChange?.Invoke(this, new EventArgs());
        } else
		{
            MonedaNoValida?.Invoke(this, new EventArgs());
        }
	}

	public double Devolver(Producto p)
	{
		return total - p.Precio;
	}
<<<<<<< HEAD
=======

>>>>>>> origin/main

    public void Iniciar()
    {
        total = 0;
    }

}
using System;

public class Cajetin
{
    public Cajetin()
    {
    }

<<<<<<< HEAD
    private double[] monedasValidas = { 2.0, 1.0, 0.5, 0.2 };
=======
    private double[] monedasValidas = {2.0, 1.0, 0.5, 0.2};
>>>>>>> 8b44d26b3eef63c10e3eebca47d738ee2d8457d3

    public event EventHandler TotalChange;
    public event EventHandler MonedaNoValida;

    private double total = 0.0;
<<<<<<< HEAD
    public double Total
=======
	public double Total
	{
		get { return total; }
		set { total = value; }
	}


	private double vuelta;
	public double Vuelta
>>>>>>> 8b44d26b3eef63c10e3eebca47d738ee2d8457d3
    {
        get { return total; }
        set { total = value; }
    }

<<<<<<< HEAD

    private double vuelta;
    public double Vuelta
    {
        get { return vuelta; }
        set { vuelta = value; }
    }

    public void Acumular(double moneda)
    {
        if (monedasValidas.Contains(moneda))
        {
            total += moneda;
            TotalChange?.Invoke(this, new EventArgs());
        }
        else
        {
            MonedaNoValida?.Invoke(this, new EventArgs());
        }
    }

    public bool Dispensar(Producto p)
    {
        if (total >= p.Precio)
        {
            return true;
        }
        return false;
    }
=======
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

    public bool Dispensar(Producto p)
	{
		if (total >= p.Precio)
		{
			return true;
		}
		return false;
	}

	public double Devolver(Producto p)
	{
		return total - p.Precio;
	}
>>>>>>> 8b44d26b3eef63c10e3eebca47d738ee2d8457d3

    public double Devolver(Producto p)
    {
        return total - p.Precio;
    }

    public void Iniciar()
    {
        total = 0;
    }

}
using System;

public class TipoSurtidor
{
	public TipoSurtidor(double precio, double caudal)
	{
		this.precio = precio;
		this.caudal = caudal;
	}

	public event EventHandler CambioLitros;
    public event EventHandler TopeAlcanzado;

    public double precio;
    public double caudal;


    public double Importe
	{
		get { return Litros * precio; }
	
	}

    public double Litros { get; set; }

	public void iniciar()
	{
		Litros = 0.0;
	}

	public double surtir(double dinero)
	{

		Litros += caudal;
		
        CambioLitros?.Invoke(this, new EventArgs());

		if (Importe >= dinero)
		{
			TopeAlcanzado?.Invoke(this, new EventArgs());
        }

        return Importe;
	}

}

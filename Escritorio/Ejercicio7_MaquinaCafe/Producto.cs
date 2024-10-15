using System;

public class Producto
{
	public Producto(string nombre, double precio)
	{
        this.nombre = nombre;
        this.precio = precio;
	}

    private string nombre;
    public string Nombre
    {
		get { return nombre; }
		set { nombre = value; }
	}

    private double precio;
    public double Precio
    {
        get { return precio; }
        set { precio = value; }
    }

}


public class Producto {
	int codigo;
	String nombre;
	double precio;
	int stock;
	int puntoReposicion;//El stock debe ser igual a esoto para reponer articulos

	public void Codigo(int valor){codigo=valor;}
	public void Nombre(String valor){nombre=valor;}
	public void Precio(double valor){precio=valor;}
	public void Stock(int valor){stock=valor;}
	public void PuntoReposicion(int valor){puntoReposicion=valor;}
	
	public int Codigo(){return codigo;}
	public String Nombre(){return nombre;}
	public double Precio(){return precio;}
	public int Stock(){return stock;}
	public int PuntoReposicion(){return puntoReposicion;}
	
	public String toString(){return "El aticulo"+nombre+" con codigo N°"+codigo+" cuesta $"+precio+", hay "+stock+" unidades en existencia y para reponer el producto en cuestion debe haber a lo sumo "+puntoReposicion+" unidades en existencia.";}
	
	public Producto()
	{
		codigo=0;
		nombre="";
		precio=0;
		stock=0;
		puntoReposicion=0;
	}
}

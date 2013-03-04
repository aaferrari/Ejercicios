public class Planta
{ //Atributos.
	private String nombre;
	private int tipo;
	private int cantidad;
	private int stock;
	private float precio;
	
	//Métodos.
	public Planta()
	{ nombre="";
	tipo=0;
	cantidad=0;
	stock=0;
	precio=0;}
	
	public Planta(String n,int t,int c,int s, float p)
	{ nombre=n;
	tipo=t;
	cantidad=c;
	stock=s;
	precio=p;}
	
	public String getNombre(){ return nombre;}
	public int getTipo()	{ return tipo;}
	public int getCantidad(){ return cantidad;}
	public int getStock(){ return stock;}
	public float getPrecio()	{ return precio;}
	
	public void setNombre(String n)	{ nombre=n;}
	public void setTipo(int t)	{ tipo=t;}
	public void setCantidad(int c)	{ cantidad=c;}
	public void setStock(int s)	{ stock=s;}
	public void setPrecio(float p)	{ precio=p;}
	
	public String toString()
	{ return nombre+ "" + tipo+ " "+ cantidad+ " " + stock+ " " + precio;}
}
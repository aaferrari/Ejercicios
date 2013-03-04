import java.io.Serializable;

public class Alumno implements Serializable {
	int legajo;
	String nombre;
	float promedio;
	float precio;
	
	public void setLegajo(int valor){legajo=valor;}
	public void setNombre(String valor){nombre=valor;}
	public void setPromedio(float valor){promedio=valor;}
	public void setPrecio(float valor){precio=valor;}
	public int getLegajo(){return legajo;}
	public String getNombre(){return nombre;}
	public float getPrecio(){return precio;}
	public float getPromedio(){return promedio;}
	
	public String toString(){return nombre+" con legajo N°"+legajo+" tiene un promedio de "+promedio+" y vale unos $"+precio+" en el mercado de esclavos ;-)";}
	public Alumno(){
		legajo=0;
		nombre="";
		promedio=0;
		precio=0;
	}
}

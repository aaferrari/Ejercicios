
public abstract class Persona {
	public String apellido;
	public String nombre;
	
	public void setApellido(String valor) { apellido=valor; }
	public void setNombre(String valor) { nombre=valor; }
	
	public String getApellido() { return apellido; }
	public String getNombre() { return nombre; }
	
	public String toString(){return nombre+" "+apellido;}
	
	public Persona()
	{apellido="";
	nombre="";
	}
}

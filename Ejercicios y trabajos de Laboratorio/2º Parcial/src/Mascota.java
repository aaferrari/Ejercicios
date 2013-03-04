
public abstract class Mascota {

	String nombre;
	String fechaNacimiento;

	public void getNombre(String valor){nombre=valor;}
	public void getFechaNacimiento(String valor){fechaNacimiento=valor;}
	public String setNombre(){return nombre;}
	public String setFechaNacimiento(){return fechaNacimiento;}

	public String toString(){return " se llama "+nombre +", nacio el dia "+fechaNacimiento;}

	public Mascota()
	{
		nombre="";
		fechaNacimiento="";
	}
}

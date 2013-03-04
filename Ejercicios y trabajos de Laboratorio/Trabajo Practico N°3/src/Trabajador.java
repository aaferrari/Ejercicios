
public abstract class Trabajador {
	String nombre;
	String puesto;
	String direccion;
	long telefono;//Ya que los numeros telefonicos pueden llegar a ser numeros grandes (teniendo en cuenta los codigos de area que pudiera haber, entonces escribo este atributo como long
	String fechaNacimiento;
	int dni;
	
	public void setNombre(String valor){nombre=valor;}
	public void setPuesto(String valor){puesto=valor;}
	public void setDireccion(String valor){direccion=valor;}
	public void setTelefono(long valor){telefono=valor;}
	public void setFechaNacimiento(String valor){fechaNacimiento=valor;}
	public void setDNI(int valor){dni=valor;}
	
	public String getNombre(){return nombre;}
	public String getPuesto(){return puesto;}
	public String getDireccion(){return direccion;}
	public long getTelefono(){return telefono;}
	public String getFechaNacimiento(){return fechaNacimiento;}
	public int getDNI(){return dni;}
	
	public String toString(){
		return " se llama "+nombre+", vive en "+direccion+", su telefono es "
		+telefono+", nacio el "+fechaNacimiento+" y su DNI es "+dni+
		".\nActualmente se encuentra en el puesto de "+puesto+".";
	}
	
	public Trabajador(){
		nombre="";
		puesto="";
		direccion="";
		telefono=0;
		fechaNacimiento="";
		dni=0;
	}
	
	public abstract float calcularSueldo();
}

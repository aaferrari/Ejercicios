//Una forma de determinar que profesion es de cada uno se puede hacer una clase por cada profesion y cuando haga falta, se
public abstract class Persona {
	public int dni;
	public String nombre;
	public String direccion;
	public byte tipoDocumento;
	
	public int getDni(){ return dni; }
	public String getNombre(){ return nombre; }
	public String getDireccion(){ return direccion; }
	public byte getTipoDocumento(){ return tipoDocumento; }
	
	public void setDni(int valor){ dni=valor; }
	public void setNombre(String valor){ nombre=valor; }
	public void setDireccion(String valor){ direccion=valor; }
	public void setTipoDocumento(byte valor){ tipoDocumento=valor; }
	
	public String Documentador(byte documento)
	{
		switch(documento){
			case 0: 
				return "DNI";
			case 1:
				return "Libreta de enrolamiento";
			case 2:
				return "Libreta de c...";
			case 3:
				return "Tipo de documento desconocido (otro)";
			default://Agrego este default o sino el metodo no reconoce los retorno de los cases
				return "No se ingreso ningun tipo o no coincide con los tipos almacenados";
		}
	}
	
	public Persona()
	{
		dni=0;
		nombre="";
		direccion="";
		tipoDocumento=0;
	}
}

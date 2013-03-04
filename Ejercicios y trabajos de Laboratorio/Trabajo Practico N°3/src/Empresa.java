
public class Empresa {
	String razonSocial;
	String direccion;
	int cantidadTrabajadores;
	Trabajador[] trabajadores;
	
	public void setRazonSocial(String valor){razonSocial=valor;}
	public void setDireccion(String valor){direccion=valor;}
	public void setCantidadTrabajadores(int valor){cantidadTrabajadores=valor;}
	public void setTrabajadores(Trabajador[] valor){trabajadores=valor;}
	
	public String getRazonSocial(){return razonSocial;}
	public String getDireccion(){return direccion;}
	
	public Trabajador[] getTrabajadores(){return trabajadores;}
	public int getCantidadTrabajadores(){return cantidadTrabajadores;}
	
	public void inicializadorVectorial(){//Escribo este metodo para poder inicializar el vector con la cantidad de trabajadores que piensa agregar el usuario durante la ejecucion del programa
		trabajadores=new Trabajador[cantidadTrabajadores];
	}
	
	public void agregarTrabajadorAVector(Trabajador objeto, int cuentaInserciones){
		trabajadores[cuentaInserciones]=objeto;
	}
	
	public Empresa(){
		razonSocial="";
		direccion="";
		cantidadTrabajadores=0;
		trabajadores=null;
	}
	
}

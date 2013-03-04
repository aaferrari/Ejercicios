
public class Cliente extends Persona{
	int numeroCliente;
	String domicilio;
	
	public void setNumeroCliente(int valor){numeroCliente=valor;}
	public void setDomicilio(String valor){domicilio=valor;}
	
	public int getNumeroCliente(){return numeroCliente;}
	public String gerDomicilio(){return domicilio;}
	
	public String toString(){return "Numero del cliente: "+numeroCliente+"\nNombre: "+super.toString()+"\nDomicilio: "+domicilio+"\n--------------";}
	
	public Cliente()
	{super();
	numeroCliente=0;
	domicilio="";
	}
}

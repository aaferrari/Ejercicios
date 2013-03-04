
public class Tecnico extends Persona {
	byte nroTecnico;
	
	public void setNroTecnico(byte valor){nroTecnico=valor;}
	public byte getNroTecnico(){return nroTecnico;}
	//Sio el siguiente metodo se llegase a usar, deberia salir algo como 
	public String toString(){return "El tecnico asignado para la tarea tiene es el N°"+nroTecnico+" y se llama "+super.toString();}

	public Tecnico()
	{
		super();//invoco al constructor por defecto de Persona
		nroTecnico=0;
	}
}

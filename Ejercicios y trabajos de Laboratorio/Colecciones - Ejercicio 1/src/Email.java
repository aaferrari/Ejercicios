
public class Email {
	String origen;
	String destino;
	String mensaje;
	int cantidadPalabras;
	byte prioridad; //1-baja,2-normal,3-alta
	
	public void getOrigen(String valor){origen=valor;}
	public void getDestino(String valor){destino=valor;}
	public void getMensaje(String valor){mensaje=valor;}
	public void getCantidadPalabras(int valor){cantidadPalabras=valor;}
	public void getPrioridad(byte valor){prioridad=valor;}
	
	public String setOrigen(){return origen;}
	public String setDestino(){return destino;}
	public String setMensaje(){return mensaje;}
	public int setCantidadPalabras(){return cantidadPalabras;}
	public byte setPrioridad(){return prioridad;}
	
	public String Priorizador(byte prioridad)
	{
		String retorno="";
		switch(prioridad){
		case 1: retorno="Baja (no importa si lo lees o no)";
		case 2: retorno="Normal";
		case 3: retorno="Alta (mejor sera leerlo , quizas y hasta te esten avisando de un peligro apocaliptico)";
		}
		return retorno;
	}
	
	public String toString(){return "De: "+origen+"\nPara: "+destino+"\nEl mensaje tiene "+cantidadPalabras+" palabras y es de prioridad "+Priorizador(prioridad)+"\nContenido del mensaje: "+mensaje;}
	
	public Email()
	{
		origen="";
		destino="";
		mensaje="";
		cantidadPalabras=0;
		prioridad=0;
	}
	
}

import java.io.Serializable;

public class Participante implements Serializable {
	byte numeroroParticipante;
	String nombre;
	String marcaAuto;
	byte posicionLlegada;
	
	public void setNumeroroParticipante(byte valor){numeroroParticipante=valor;}
	public void setNombre(String valor){nombre=valor;}
	public void setPosicionLlegada(byte valor){posicionLlegada=valor;}
	public void setMarcaAuto(String valor){marcaAuto=valor;}
	public byte getNumeroroParticipante(){return numeroroParticipante;}
	public String getNombre(){return nombre;}
	public byte getPosicionLlegada(){return posicionLlegada;}
	public String getMarcaAuto(){return marcaAuto;}
	
	public String toString(){
		return "El participante N°"+numeroroParticipante+" se llama "+nombre+", tiene un "+marcaAuto+" y llego en la posicion "+posicionLlegada;
	}
	
	public Participante(){
		numeroroParticipante=0;
		nombre="";
		marcaAuto="";
		posicionLlegada=0;
	}
}

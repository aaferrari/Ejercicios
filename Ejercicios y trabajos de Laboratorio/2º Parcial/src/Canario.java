import java.io.Serializable;


public final class Canario extends Mascota implements Serializable {
	String origen;
	public void getOrigen(String valor){origen=valor;}
	public String setOrigen(){return origen;}

	public String toString(){return "El canario"+super.toString()+" y su origen es "+origen;}

	public Canario()
	{
		super();
		origen="";
	}
}

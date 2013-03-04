import java.io.Serializable;


public final class Perro extends Mascota implements Serializable {

	String raza;
	public void getRaza(String valor){raza=valor;}
	public String setRaza(){return raza;}

	public String toString(){return "El perro"+super.toString()+" y es de la raza "+raza;}

	public Perro()
	{
		super();
		raza="";
	}
}

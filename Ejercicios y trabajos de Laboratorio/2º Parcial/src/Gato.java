import java.io.Serializable;


public final class Gato extends Mascota implements Serializable {

	String color;
	public void getColor(String valor){color=valor;}
	public String setColor(){return color;}

	public String toString(){return "El gato"+super.toString()+" y es de color "+color;}

	public Gato()
	{
		super();
		color="";
	}
}

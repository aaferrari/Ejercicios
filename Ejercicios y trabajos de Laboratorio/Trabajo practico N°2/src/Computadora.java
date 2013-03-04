
public class Computadora {
	public String marca;
	public String modelo;
	public String capacidadDiscoDuro;//Creo estos dos ultimos atributos como cadenas para poder ponerle la unidad de medida de su capadicad (MB, GB, TB, etc)
	public String memoria;
	
	public void setMarca(String valor){marca=valor;}
	public void setModelo(String valor){modelo=valor;}
	public void setCapacidadDiscoDuro(String valor){capacidadDiscoDuro=valor;}
	public void setMemoria(String valor){memoria=valor;}
	
	public String setMarca(){return marca;}
	public String setModelo(){return modelo;}
	public String setCapacidadDiscoDuro(){return capacidadDiscoDuro;}
	public String setMemoria(){return memoria;}
	
	public String toString(){return "La computadora a reparar es un "+marca+" "+modelo+" con un disco duro de "+capacidadDiscoDuro+" y con "+memoria+" de memoria RAM.";}
	
	public Computadora()
	{
		marca="";
		modelo="";
		capacidadDiscoDuro="";
		memoria="";
	}
}


public final class Consultor extends Trabajador {
	int horasTrabajadas;
	float tarifa;
	
	public void setHorasTrabajadas(int valor){horasTrabajadas=valor;}
	public void setTarifa(float valor){tarifa=valor;}
	
	public int getHorasTrabajadas(){return horasTrabajadas;}
	public float getTarifa(){return tarifa;}

	public float calcularSueldo() {
		// TODO Auto-generated method stub
		return horasTrabajadas*tarifa;
	}
	
	public String toString(){return "El consultor"+super.toString()+"\nEl cobra $"+tarifa+" y trabajo "+horasTrabajadas+" horas, por lo que le corresponden $"+ calcularSueldo()+" en concepto de tarifacion.";}

	public Consultor(){
		super();
		horasTrabajadas=0;
		tarifa=0;
	}
}

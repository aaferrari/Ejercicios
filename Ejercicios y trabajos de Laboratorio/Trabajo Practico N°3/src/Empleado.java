
public final class Empleado extends Trabajador{
	float sueldo;
	float impuestos;
	
	public void setSueldo(float valor){sueldo=valor;}
	public void setImpuestos(float valor){impuestos=valor;}
	
	public float getSueldo(){return sueldo;}
	public float getImpuestos(float valor){return impuestos;}
	
	public float calcularSueldo(){
		return (sueldo-impuestos)/14;
	}
	
	public String toString()
	{return "El empleado"+super.toString()+"\nEl sueldo bruto del empleado es de $"+sueldo+" y si descontando $"+impuestos+" en concepto de impuestos, entonces obtenemos $"+calcularSueldo()+" de sueldo final.";}
	
	public Empleado(){
		super();
		sueldo=0;
		impuestos=0;
	}
}

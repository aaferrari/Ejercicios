public class Programa {

	public Programa() {
		// TODO Auto-generated constructor stub
	}

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int cantidadAlumnos;
		float nota;
		System.out.println("Ingrese la cantidad de alumnos a calcular: ");
		
		//Valido que no se ingrese un numero de alumnos menor a 1
		do{
		cantidadAlumnos = In.readInt();
		System.out.println("Lo sentimos, pero la cantidad de alumnos debe ser mayor a "+cantidadAlumnos+ "\nIngrese la cantidad de alumnos a calcular: ");
		}while (cantidadAlumnos < 1);
		
		ArregloNotas chiquillosConsentidos = new ArregloNotas(cantidadAlumnos);// instanciamos el arreglo
		System.out.println("Cargar el arreglo... ");
		
		for(int i=0;i<cantidadAlumnos;i++)
		{ System.out.println("Ingrese la nota del alumno N°" + (i+1));
		nota=In.readFloat();
		chiquillosConsentidos.setArregloNotas(i,nota); }// carga los datos en el vector
		
		//muestra el promedio de las notas
		System.out.println("El promedio de notas es: "+chiquillosConsentidos.Promediador());
		System.out.println("Los elementos del arreglo son: ");
		for(int i=0;i<cantidadAlumnos;i++)
		System.out.println(chiquillosConsentidos.getArregloNotas(i)+ "*");// muestra los datos del vector
	}

	public static class ArregloNotas//Sin el atributo static, la clase da problemas para instanciarla
	{
		public float[] notas;

		public ArregloNotas(int valor)
		{
			notas = new float[valor];
		}
		//carga una nota en cada componente del arreglo.
		public void setArregloNotas(int valor1,float valor2){ notas [valor1] = valor2;}
		//muestra los datos del arreglo.
		public float getArregloNotas(int valor){ return notas[valor];}
		//retorna la suma las notas medias
		public float SumaNotas()
		{
			float suma = 0;
			for (int entero = 0; entero < notas.length; entero++) //suma todas las notas
				suma += notas[entero];
			return suma;
		}
		//retorna el promedio de las notas
		public float Promediador()
		{
			float promedio;
			promedio = SumaNotas() / notas.length;
			return promedio;
		}
	}//fin
}

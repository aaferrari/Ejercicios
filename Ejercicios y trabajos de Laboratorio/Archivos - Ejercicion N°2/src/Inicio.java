import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Iterator;
import java.util.Vector;
import java.lang.NullPointerException;

public class Inicio {

	/**
	 * @param args
	 * @throws IOException
	 */
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Vector<Alumno> lista=new Vector<Alumno>();
		File archivo=new File("Estudiantes esclavos.dat");
		FileOutputStream Salida=new FileOutputStream(archivo);
		ObjectOutputStream SalidaObjeto=new ObjectOutputStream(Salida);
		Iterator<Alumno> iterador;
		Alumno AprendizDeEsclavo;
		try {
			FileInputStream Entrada=new FileInputStream(archivo);
			ObjectInputStream EntradaObjeto=new ObjectInputStream(Entrada);
			lista=(Vector<Alumno>)EntradaObjeto.readObject();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			archivo.createNewFile();
		}
		catch(ClassNotFoundException ClaseNoEncontrada)
		{ System.out.println("La clase que se necesita para manejar los datos que estan en el archivo, no fue encontrada, por favor contacte cn el administrador o con algun programador para ver como puede solucionar el problema. Muchas gracias");
			System.exit(0);
		}
		catch(EOFException FinalDesconocido)
		{System.out.println("El archivo esta vacio o no tiene el formato correcto.");
		}

		do{
			System.out.println("Programa para la gestion de una escuela de esclavos :-))))))\n----------------------------------------------------------");
			System.out.println("¿Que desea hacer abora (elija una opcion de la lista)?:\n0 - Salir\n1 - Calcular el promedio del promedio de los alumnos\n2 - Informar la cantidad de alumnos que regularizaron la materia \"Esclavo servicial 101\"\n3 - Mostral el alumno con la nota mas alta\n4 - Cargar nuevos datos");
			switch(In.readByte())
			{
			case 0: System.exit(0); break;
			case 1:
				{
				iterador=lista.iterator();
				float acumulador=0;
				float promedio=0;
				while (iterador.hasNext() == true)
					{
					AprendizDeEsclavo=new Alumno();
					AprendizDeEsclavo=(Alumno)iterador.next();
					acumulador=acumulador+AprendizDeEsclavo.promedio;
					}
				System.out.println("El promedio de los promedios de los \"Estudiantes\" es de "+acumulador/lista.size());//Divide la suma de los promedios con la cantidad de elementos de la lista
				break;
				}
			case 2:
				{//Ejemplo de un recorrido de lista hecho con un while
					int regulares=0;
					int contador=0;
					while (contador < lista.size())
						{
						if (lista.get(contador).promedio >= 6) regulares++;
						contador++;
						}
					System.out.println("Solo hay "+regulares+" alumnos lo suficientemente buenos como para ser regulares");
					break;
				}
			case 3:
				{
					AprendizDeEsclavo=null;
					float mayorNota=0;
					for (int contador=0;contador < lista.size();contador++)
					{
						AprendizDeEsclavo=lista.get(contador);
						if (AprendizDeEsclavo.promedio > mayorNota) mayorNota=AprendizDeEsclavo.promedio;
						contador++;
					}
					System.out.println("El aprendiz mas sobresaliente tiene un promedio de "+mayorNota+" y estos son sus datos: "+AprendizDeEsclavo.toString());
					break;
				}
			case 4:
				{
					while("esto es un bucle infinito".equals("esto es un bucle infinito"))
					{
					AprendizDeEsclavo=new Alumno();
					System.out.println("Nombre de... eso: ");
					AprendizDeEsclavo.nombre=In.readLine();
					System.out.println("Numero de legajo (¿o deberia decir de esclavo?): ");
					AprendizDeEsclavo.legajo=In.readInt();
					System.out.println("Nota promedio de sus materias esclavicias: ");
					AprendizDeEsclavo.promedio=In.readFloat();
					System.out.println("Precio (para cuando termine la ecuelita y tenga que ser coimprado en el mercado de esclavos)");
					AprendizDeEsclavo.precio=In.readFloat();
					if (AprendizDeEsclavo.nombre=="" || AprendizDeEsclavo.legajo ==0 || AprendizDeEsclavo.precio == 0 || AprendizDeEsclavo.promedio == 0) break;//Esto verifica que si algun dato esta vacio, entonces que termine con el bucle
					else lista.add(AprendizDeEsclavo);
					}
					SalidaObjeto.writeObject(lista);
					break;
				}
			}
		}while(3.1415926535897932384626433832795==3.1415926535897932384626433832795);


	}

}

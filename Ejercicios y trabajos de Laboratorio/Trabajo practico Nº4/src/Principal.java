import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.NotSerializableException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Vector;

public class Principal {

	/**
	 * @param args
	 */
	
	public static void main(String[] args) throws IOException, ClassNotFoundException {
		
		File archivo = new File("participantes.txt");
		boolean EscribirONo=false;//Variable que luego sera utilizada para determinar que se quiere hacer con el archivo
		FileOutputStream ArchivoSalida=null;
		ObjectOutputStream Salida=null;
		Vector<Participante> Pilotos=null;//Le indico al vector que solo agrege objetos de la clase "Participante" debido a que siempre se van a agregar los objetos de la misma clase
		
		System.out.println("Programa de para manejo de datos de los participantes de la carrera" +
				" (tenga en cuenta que a la hora de inseertar datos, tanto el numero del participante" +
				" como su posicion de llegada a la meta NO deben excederse de 128)");
		
		if (archivo.exists() == true){//Comprueba si el archivo existe y el try-catch es para atrapar las posibles excepciones que puedan aparecer
			try{
				FileInputStream ArchivoEntrada=new FileInputStream(archivo);
			ObjectInputStream Entrada;
			Entrada = new ObjectInputStream(ArchivoEntrada);
			Pilotos=(Vector<Participante>)Entrada.readObject();
			System.out.println("Actualmente existen "+Pilotos.size()+" participantes registrados");
			System.out.println("------------------------------------------------");
			for (int contador=0;contador < Pilotos.size();contador++)
				{System.out.println("Piloto Nº"+(contador+1)+": "+ Pilotos.elementAt(contador).toString());}//Obtiene el objeto de la posicion indicada y ejecuta el metodo toString()
			Entrada.close();
			ArchivoEntrada.close();
			}
			catch(EOFException ExcepcionArchivoIncompleto){
				System.out.print("El archivo "+archivo.getName()+ " no tiene el formato correcto o no existe, terminando ejecucion del programa");
				System.exit(0);
			}
			catch(NotSerializableException archivoNoSerializable){
				System.out.print("El contenido del archivo "+archivo.getName()+ " no es serializable, por lo que es posible que este dañado o no tenga el formato correcto.\nTerminando ejecucion del programa");
				System.exit(0);
			}
		}
		else{
			ArchivoSalida=new FileOutputStream(archivo);
			Salida= new ObjectOutputStream(ArchivoSalida);
			EscribirONo=true;
			Pilotos=new Vector<Participante>();
		}
		
		if (EscribirONo==false) {//Comprueba si se quieren agregar mas datos en el archivo preexistente y si responde con 1, entonces se crean un FileOutputStream y on ObjectOutputStream, sino el programa termina su ejecucion
			System.out.println("¿Desea agregar mas participantes?: ");
			String respesta=In.readString();
			if (respesta.equalsIgnoreCase("si")){
				ArchivoSalida=new FileOutputStream(archivo);
				Salida= new ObjectOutputStream(ArchivoSalida);	
			}
			else System.exit(0);
		}
		
		do{
			Participante Piloto=new Participante();
			System.out.println("¿Cual es el numero con el que participa el piloto?: ");
			Piloto.numeroroParticipante=In.readByte();
			if (Piloto.numeroroParticipante == 0) break;//Si el numero es 0, entonces salta del bucle y continua con la ejecucion del programa hasta terminar
			System.out.println("¿Como se llama el piloto?: ");
			Piloto.nombre=In.readLine();
			System.out.println("¿Cual es la marca del auto?: ");
			Piloto.marcaAuto=In.readLine();
			System.out.println("¿En que posicion llego a la meta?: ");
			Piloto.posicionLlegada=In.readByte();
			Pilotos.addElement(Piloto);
			System.out.println("Participantes guardados hasta el momento:");
			for (int contador=0;contador < Pilotos.size();contador++)//Este piloto va mostrando los pilotos que existen actualmente (asi se comprueba que no falte nada)
				{System.out.println("Piloto Nº"+(contador+1)+": "+ Pilotos.elementAt(contador).toString());}
		}while (1==1);//Ejecuta el bucle infinitamente (porque 1 siempre va a ser igual a 1) hasta que el numero de participante sea igual a 0

		//Por ultimo, se guarda el Vector en el archivo y sale
		Salida.writeObject(Pilotos);
		ArchivoSalida.close();
		System.out.println("Saliendo...");
	}
}
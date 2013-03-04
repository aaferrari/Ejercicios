import java.util.ArrayList;
import java.util.Iterator;


public class AplicacionMaestra {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		ArrayList<Email> Mensajes=new ArrayList<Email>();
		Iterator<Email> iterador;
		Email CorreoE;
		byte eleccion;
		
		do{
			System.out.println("Probama basico de mensajeria\n---------------------");
			System.out.println("Elija que accion desea realizar:\n0 - Salir\n1 - Agregar nuevo mensaje" +
					"\n2 - Borrar mensaje existente\n3 - Mostrar mensajes recibidos\n4 - Mostrar la cantidad de" +
					" palabras que tiene un determinado mail\n5 - Mostrar la cantidad total de palabras de todos los mensajes");
			eleccion=In.readByte();
			
			//try{
			switch(eleccion){
			case 0:{System.exit(eleccion);}//Termina el programa directamente
			case 1:
			{
				CorreoE=new Email();
				System.out.println("¿De parte de quien es el mensaje?: ");
				CorreoE.origen=In.readString();
				System.out.println("¿A donde sera enviado el mensaje?: ");
				CorreoE.destino=In.readString();
				System.out.println("¿Que prioridad tiene (1-baja,2-normal,3-alta)?: ");
				CorreoE.prioridad=In.readByte();
				System.out.println("A continuacion escriba lo que quiera decirle a "+CorreoE.destino+", pero recuerde que la tecla enter solo se puede usar para cuando se termina de escribir el mensaje. ");
				CorreoE.mensaje=In.readLine();
				CorreoE.cantidadPalabras=CorreoE.mensaje.split(" ").length;//Esto crea un array dividiendo todas las palabras a partir de sus espacios y luego obtiene la cantidad de elementos que hay en el mismo y es lo que se guarda en el correspondiente atributo
				System.out.println("En el mensaje se han escrito "+CorreoE.cantidadPalabras+" palabras.");
				Mensajes.add(CorreoE);
				break;//No sepor que siempre se me olvida poner esto, ya que sino lo hago entonces el programa ejecutara todos los cases
			}
			case 2:
			{
				System.out.println("Escriba el numero de mensaje a borrar empezando desde el 0");
				Mensajes.remove(In.readInt());
				System.out.println("Mensaje borrado");
				break;
			}
			case 3:
			{
				iterador=Mensajes.iterator();
				CorreoE=new Email();
				int cantidadMensajes=1;
				while(iterador.hasNext() == true)//Si el iterador tiene mas elementos, entonces eso sera true
				{
					CorreoE=(Email)iterador.next();
					System.out.println("Mensaje N°"+cantidadMensajes+"\n"+CorreoE.toString());
					cantidadMensajes++;
				}
				break;
			}
			case 4:
			{
				System.out.println("Escriba el numero de mensaje que quiere revisar: ");
				int mensajeElegido=In.readInt();
				System.out.println("El mensaje "+mensajeElegido+" tiene " +Mensajes.get(mensajeElegido).cantidadPalabras+ " palabras");
				break;
			}
			case 5:
			{
				iterador=Mensajes.iterator();
				CorreoE=new Email();
				long acumulador=0;
				while(iterador.hasNext() == true)
				{
					CorreoE=(Email)iterador.next();
					acumulador=acumulador+CorreoE.cantidadPalabras;
				}
				System.out.println("Existen "+acumulador+" palabras en todos los mensajes");
				break;
			}
			/*}
			catch(IndexOutOfBoundsException FueraDeIndice)
			{
				System.out.println("Lo sentimos, pero el/los mensaje/s que quiere revisar no existe/n");
			}*/
			}
		}while(eleccion!=0);

	}

}

import java.io.IOException;


public class Aplicacion_principal {

	/**
	 * @param args
	 * @throws IOException 
	 * @throws ClassNotFoundException 
	 */
	public static void main(String[] args) throws IOException, ClassNotFoundException {
		// TODO Auto-generated method stub
	System.out.println("Programa de ingreso de libros");
	Libro[] lista=new Libro[3];
	byte eleccion;
	do{
	do{
		System.out.println("Elija lo que desea hacer:\n1 - Ingresar datos\n2 - Leer archivo de datos\n3 - Salir");
		eleccion=In.readByte();
	}while (eleccion !=1 && eleccion !=2);//Mientras no se elija entre alguna de las dos opciones, entonces se ejecutara el bucle
	
	if (eleccion==1){
		for (byte contador=0;contador <=(lista.length-1);contador++){
			lista[contador]=new Libro();
			System.out.println("Libro N°"+(contador+1)+"\n------------");
			System.out.println("Codigo: ");
			lista[contador].codigo=In.readInt();
			System.out.println("Nombre: ");
			lista[contador].nombre=In.readLine();
			System.out.println("Precio: ");
			lista[contador].precio=In.readFloat();
		}
		Libro.Guardador("ArchivoSerializableLibros.obj", lista);

	}
	if (eleccion==2){Libro.Leedor("ArchivoSerializableLibros.obj", lista);}
	if (eleccion==3){System.exit(0);}
	}while (1==1);
	}

}

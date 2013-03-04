import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Libro implements Serializable {
	/**
	 * 
	 */
	int codigo;
	String nombre;
	float precio;
	
	public void setCodigo(int valor){codigo=valor;}
	public void setNombre(String valor){nombre=valor;}
	public void setPrecio(float valor){precio=valor;}
	public int getCodigo(){return codigo;}
	public String getNombre(){return nombre;}
	public float getPrecio(){return precio;}
	
	public Libro(){
		codigo=0;
		nombre="";
		precio=0;
	}
	
	public String ToString(){return "Nombre del libro: "+nombre+"\nCodigo: "+codigo+"\nPrecio: $"+precio;}
	
	public static void Guardador(String nombre_archivo, Libro[] VectorLibros) throws IOException{
		FileOutputStream salida;
		try{salida=new FileOutputStream(nombre_archivo);}
		catch(FileNotFoundException ArchivoNoEncontrado){
			File archivo=new File(nombre_archivo);
			salida=new FileOutputStream(archivo);
			}//Esto sirve para comprobar s el archivo existe, y si esta excepcion se cumple, entonces se creara un nuevo objeto de archivo
		//for(byte contador=3;contador!=0;contador--){
		System.out.println("Nombre del libro: ");
		ObjectOutputStream SalidaObjetos=new ObjectOutputStream(salida);
		SalidaObjetos.writeObject(VectorLibros);//Escribe el vector en el archivo
		salida.close();//Cerramos el archivo
	}
	
	public static void Leedor(String nombre_archivo, Libro[] VectorLibros) throws IOException, ClassNotFoundException{
		float precioMayor;
		FileInputStream entrada = null;
		try{
			entrada=new FileInputStream(nombre_archivo);
			ObjectInputStream EntradaObjetos=new ObjectInputStream(entrada);
			VectorLibros=(Libro[])EntradaObjetos.readObject();//Lee el vector del archivo y lo convierte en objeto
			for (byte contador=0;contador <=(VectorLibros.length-1);contador++){
				System.out.print("\n"+VectorLibros[contador].ToString());
			}
			
			do{
				System.out.println("\nMostrar libros cuyo precio sea superior a: ");
				precioMayor=In.readFloat();
				if (precioMayor==0){System.out.println("Precio incorrecto, por favor ingreselo nuevamente");}
			}while (precioMayor==0);
			
			for (byte contador=0;contador <=(VectorLibros.length-1);contador++){
				if (VectorLibros[contador].precio > precioMayor){System.out.println(VectorLibros[contador].ToString());}
			}
		}
		catch(FileNotFoundException ArchivoNoEncontrado){
			System.out.println("El archivo "+nombre_archivo+" no se encontdo en el directorio actual :-(");
		}
		catch(NullPointerException PunteroNulo){System.out.println("El archivo "+nombre_archivo+" no contiene objetos compatibles que se puedan leer :-(");}

		
	}
	}

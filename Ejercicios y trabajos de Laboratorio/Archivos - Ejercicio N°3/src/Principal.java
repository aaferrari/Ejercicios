import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.List;


public class Principal {

	/**
	 * @param args
	 * @throws IOException 
	 * @throws ClassNotFoundException 
	 */
	public static void main(String[] args) throws IOException, ClassNotFoundException {
		File Archivo=new File("Pruductos.loquesea");
		FileInputStream ArchivoEntrada=null;
		FileOutputStream ArchivoSalida=null;
		ObjectInputStream Entrada=null;
		ObjectOutputStream Salida=null;
		List<Producto> Productos=null;
		Producto cosa=null;
		
		if (Archivo.exists() == true)
		{
			ArchivoEntrada=new FileInputStream(Archivo);
			Entrada=new ObjectInputStream(ArchivoEntrada);
			Productos=(List<Producto>)Entrada.readObject();
		}
		
		System.out.println("Prigrama de manejo de productos");
		
		do{
			cosa=new Producto();
			System.out.println("Nombre del producto: ");
			cosa.nombre=In.readLine();
			System.out.println("Codigo de verificacion (o lo que sea)");
			cosa.codigo=In.readInt();
			System.out.println("Unidades en existencia");
			cosa.stock=In.readInt();
			System.out.println("Cantidad mnima que debe de haber antes de hacer reposicion: ");
			cosa.puntoReposicion=In.readInt();
			System.out.println("₱r€¢io: ");
			Productos.add(cosa);
		}while(cosa.codigo !=0||cosa.nombre !=""||cosa.precio !=0||cosa.puntoReposicion !=0||cosa.stock !=0);
		ArchivoSalida=new FileOutputStream(Archivo);
		Salida=new ObjectOutputStream(ArchivoSalida);
		Salida.writeObject(Productos);
	}

}

import java.io.*;
import java.util.Vector;
import java.util.Iterator;
import java.lang.ArrayIndexOutOfBoundsException;

public class ModuloPrincipal {

	/**
	 * @param args
	 */
	public static void main(String[] args) throws ClassNotFoundException, IOException{
		// TODO Auto-generated method stub
		File archivo=new File("MascotasRegistradas.data");
		Vector Mascotas=null;
		Perro Canino=null;
		Gato Felino=null;
		Canario Ave=null;
		int contadorPerros=0;
		int contadorGatos=0;
		int contadorCanarios=0;
		boolean condicionSalida=false;
		try{
			FileInputStream EntradaArchivo=new FileInputStream(archivo);
			ObjectInputStream EntradaObjeto=new ObjectInputStream(EntradaArchivo);
			Mascotas=(Vector)EntradaObjeto.readObject();
			Iterator iterador=Mascotas.iterator();
			
			System.out.println("Programa de carga de mascotas\n----------------------");
			
			int contadorGeneral=0;
			while(iterador.hasNext() ==true)
				{
				if(Mascotas.elementAt(contadorGeneral).equals(Perro.class) == true)
				{
					Canino=Perro.class.cast(iterador.next());
					contadorPerros++;
				}
				if(Mascotas.elementAt(contadorGeneral).equals(Gato.class) == true)
				{
					Felino=Gato.class.cast(iterador.next());
					contadorGatos++;
				}
				if(Mascotas.elementAt(contadorGeneral).equals(Canario.class) == true)
				{
					Ave=Canario.class.cast(iterador.next());
					contadorCanarios++;
				}
				contadorGeneral++;
				}
			System.out.println("Actualmente existen "+contadorPerros+" perros, "+contadorGatos+" gatos y"+contadorCanarios+" canarios cargados en el sistema");
		}

		//En caso de que el archivo no exista, el catch creara un nuevo archivo vacio y el finally creara los buferes de salida, ademas de determinar si el Vector no fue antes inicializado por el vector contenido en el archivo, entonces lo inicializara
		catch(FileNotFoundException ArchivoNoEncontrado){archivo.createNewFile();}
		catch(ArrayIndexOutOfBoundsException FueradeIndice){System.out.println("Actualmente existen "+contadorPerros+" perros, "+contadorGatos+" gatos y"+contadorCanarios+" canarios cargados en el sistema");}
		/*finally
		{*/
			FileOutputStream SalidaArchivo=new FileOutputStream(archivo);
			ObjectOutputStream SalidaObjeto=new ObjectOutputStream(SalidaArchivo);
			if(Mascotas==null)
				{Mascotas=new Vector();}
		//}

		do{
		System.out.println("Elija que mascota quiere cargar\n1 - Perro\n2 - Gato\n3 - Canario");
		byte eleccion=In.readByte();
		//Hubiera usado un switch para esto, pero ocurre que cuando se ejecuta la instruccion break, entonces corta todo el bucle y sale
		if(eleccion==1)
			{
			Canino=new Perro();
			System.out.println("¿Como se llama el perro?: ");
			Canino.nombre=In.readLine();
			System.out.println("¿De que raza es?: ");
			Canino.raza=In.readLine();
			System.out.println("¿Cuando nacio?: ");
			Canino.fechaNacimiento=In.readLine();
			if(Canino.nombre.equals("")) {condicionSalida=true;}
			else{Mascotas.add(Canino);}
			}
		if(eleccion==2)
			{
		Felino=new Gato();
		System.out.println("¿Como se llama el gato?: ");
		Felino.nombre=In.readLine();
		System.out.println("¿De que color es?: ");
		Felino.color=In.readLine();
		System.out.println("¿Cuando nacio?: ");
		Felino.fechaNacimiento=In.readLine();
		if(Felino.nombre.equals("")) {condicionSalida=true;}
		else {Mascotas.add(Felino);}
			}
		if(eleccion==3)
			{
		Ave=new Canario();
		System.out.println("¿Como se llama el canario?: ");
		Ave.nombre=In.readLine();
		System.out.println("¿Cusal es su origen?: ");
		Ave.origen=In.readLine();
		System.out.println("¿Cuando nacio?: ");
		Ave.fechaNacimiento=In.readLine();
		if(Ave.nombre.equals("")) {condicionSalida=true;}
		else{Mascotas.add(Ave);}
			}

		}while ( condicionSalida==false);
		SalidaObjeto.writeObject(Mascotas);
		
		for(int contador=0;contador < Mascotas.size(); contador++)//Recorre la lista y ejecuta todos los metodos toString de las clases
			{System.out.println(Mascotas.get(contador).toString());}
		
	}

}

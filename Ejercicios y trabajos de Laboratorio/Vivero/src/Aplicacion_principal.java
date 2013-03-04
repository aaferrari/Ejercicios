
public class Aplicacion_principal {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//Declaración de varaibles auxiliares.
		String razonSocial,direccion,nombre;
		int cantidadPlantas,tipoPlanta,cantidad,stock;
		float precio;
		//Cargo los datos del vivero
		System.out.println("Ingrese la razon social:");
		razonSocial=In.readLine();
		System.out.println("Ingrese la direccion:");
		direccion=In.readLine();
		System.out.println("Ingrese cantidad de plantas:");
		cantidadPlantas=In.readInt();
		//Creo obj. Vivero
		Vivero v=new Vivero(razonSocial,direccion,cantidadPlantas);
		//Cargo el arreglo con plantas.
		for(int i=0;i<cantidadPlantas;i++)
		{ //Creo un obj. planta
		System.out.println("Ingrese nombre:");
		nombre=In.readString();
		System.out.println("Ingrese tipo:");
		tipoPlanta=In.readInt();
		System.out.println("Ingrese cantidad:");
		cantidad=In.readInt();
		System.out.println("Ingrese stock:");
		stock=In.readInt();
		System.out.println("Ingrese precio:");
		precio=In.readFloat();
		Planta p1= new Planta(nombre, tipoPlanta, cantidad, stock, precio);
		v.setPlanta(i,p1);
		}
		System.out.println("Un elemento: " + v.getPlanta(0));
		System.out.println("Total de stock: " + v.TotalStock());
		System.out.println("Plantas a Reponer: " + v.StockMinimo());
		System.out.println("Cantidad por Tipo: " + v.PlantaxTipo());
		System.out.println("La planta que mayor stock tiene: " + v.MayorStock());
	}

}

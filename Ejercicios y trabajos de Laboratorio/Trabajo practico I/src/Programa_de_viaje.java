public class Programa_de_viaje {

	/**
	 * @param args
	 */

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int ingresos;//Cantidad de ingresos que se van a hacer
		int despachados=0;//Este servira de acumulador para ser usado en el array
		System.out.println("¿Cuantos viajeros piensa agregar hoy?");
		ingresos=In.readInt();
		Viaje[] Registro=new Viaje[ingresos];
		do
		{
		System.out.println("\nViajero N°"+(despachados+1));
		Registro[despachados]=new Viaje();
		System.out.println("Escriba el DNI del viajero:");
		Registro[despachados].dni=In.readInt();
		System.out.println("Escriba su apellido:");
		Registro[despachados].apellido=In.readString();
		System.out.println("Escriba su nombre:");
		Registro[despachados].nombre=In.readString();
		System.out.println("Elija el tipo de viaje:\n1 - estándar\n2 - económica");
		Registro[despachados].tipoViaje=In.readByte();
		System.out.println("Elija el destino:\n1 - Bariloche\n2 - Cataratas del Iguazú\n3 - Mendoza");
		Registro[despachados].destino=In.readByte();
		System.out.println("Ingrese el costo inicial del viaje:");
		Registro[despachados].costoBase=In.readDouble();
		System.out.println("-------------------------");
		System.out.println(Registro[despachados].toString());
		System.out.println("-------------------------");
		despachados++;
		ingresos--;
		}while (ingresos!=0);
		
		double preciosFinales=0;
		int viajesEconomicos=0;
		int viajeEstandarCataratas=0;
		double preciosViajesEstandares=0;
		for (int contador = 0; contador < Registro.length; contador++)
		{
			preciosFinales+=Registro[contador].costoFinal();
			if(Registro[contador].tipoViaje==2)
			{viajesEconomicos++;}
			if(Registro[contador].tipoViaje==1&&Registro[contador].destino==2)
			{viajeEstandarCataratas++;}
			if(Registro[contador].tipoViaje==1)
			{preciosViajesEstandares+=Registro[contador].costoFinal();}
		}
		System.out.println("============================");
		System.out.println("Precio final de todos los viajes comercializados: $"+preciosFinales);
		System.out.println("Cantidad de viajes comercializados de clase económica: "+viajesEconomicos);
		System.out.println("Viajes cuyo destino sean las Cataratas del Iguazú y de clase estándar: "+viajeEstandarCataratas);
		System.out.println("Monto total de viajes de clase estándar: $"+preciosViajesEstandares);
	}
	
	public static class Viaje{//http://episteme.arstechnica.com/eve/forums/a/tpc/f/6330927813/m/1631041
		public int dni;
		public String apellido;
		public String nombre;
		public byte tipoViaje;
		public byte destino;
		public double costoBase;
		
		public void setDNI(int valor) { dni=valor; }
		public void setApellido(String valor) { apellido=valor; }
		public void setNombre(String valor) { nombre=valor; }
		public void setTipoViaje(byte valor) { tipoViaje=valor; }
		public void setDestino(byte valor) { destino=valor; }
		public void setCostoBase(double valor) { costoBase=valor; }
		
		public int getDNI() { return dni; }
		public String getApellido() { return apellido; }
		public String getNombre() { return nombre; }
		public byte getTipoViaje() { return tipoViaje; }
		public byte getDestino() { return destino; }
		public double getCostoBase() { return costoBase; }
		
		public double costoIntermedio(byte destino)
		{
			double precioIntermedio;
			switch (destino){ 
				case 1:
					{precioIntermedio=((this.costoBase*5)/100)+costoBase;
					return precioIntermedio;
					}
				case 2:
					precioIntermedio=((this.costoBase*3)/100)+costoBase;
					return precioIntermedio;
				case 3:
					precioIntermedio=((this.costoBase*2)/100)+costoBase;
					return precioIntermedio;
				default:
					return 0;
					}
		}
		
		public String Destinador()
		{
			switch (destino){ 
			case 1:
				return "Bariloche";
			case 2:
				return "Cataratas del Iguazú";
			case 3:
				return "Mendoza";
			default:
				return "No se seleciono ningun destino";
				}
		}
		
		public String Clasificador()
		{
			String claseViaje=null;
			if(tipoViaje==1)
				claseViaje="Estándar";
			if(tipoViaje==2)
				claseViaje="Económica";
			return claseViaje;
		}
		
		public double costoFinal()
		{
			double precioFinal=0;
			if (tipoViaje==1)
			{precioFinal=costoIntermedio(tipoViaje)+30;}
			if (tipoViaje==2)
			{precioFinal=costoIntermedio(tipoViaje)+15;}
			return precioFinal;
		}
		
		public String toString()
		{
			return "DNI del viajero: "+dni+
			"\nApellido y nombre: " +apellido+" "+nombre+
			"\nTipo de viaje elegido: "+Clasificador()+
			"\nDestino elegido: "+Destinador()+
			"\nCosto bruto (o base) del viaje: $" +costoBase+
			"\nCosto neto (o total) del viaje: $" +costoFinal();
		}
		
		public Viaje(){
			dni=0;
			apellido="";
			nombre="";
			tipoViaje=0;
			destino=0;
			costoBase=0;
		}
	}

}


public class Rutina_principal {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int tecnicosIngresados=0;
		int mantenimientosIngresados=0;
		System.out.println("Programa de registracion de mantenimiento de equipos informaticos\n");
		System.out.println("¿Cuantos tecnicos hay?");
		int cantidadTecnicos=In.readInt();
		Tecnico[] vectorTecnico=new Tecnico[cantidadTecnicos];

		do {//Esto ingresa solamente los tecnocos del lugar
			vectorTecnico[tecnicosIngresados]=new Tecnico();
			System.out.println("Tecnico N°"+(tecnicosIngresados+1));
			System.out.println("Numero (puede ser 1, 2 o 3):");
			vectorTecnico[tecnicosIngresados].nroTecnico=In.readByte();
			//El siguiente while verifica si el numero del tecnico esta entre 1, 2 o 3
			while(vectorTecnico[tecnicosIngresados].nroTecnico < 1 || vectorTecnico[tecnicosIngresados].nroTecnico > 3){//Mientras el numero del tecnico sea menor a 1 o mayor a tres, entonces mostrara un mensaje de error y pedira quew se lo ingrese nuevamente hasta que se deje de cumplir esa condicion
				System.out.println("Numero de tecnico incorrecto, intentelo nuevamente");
				System.out.println("Numero (puede ser 1, 2 o 3):");
				vectorTecnico[tecnicosIngresados].nroTecnico=In.readByte();
			}
			System.out.println("Nombre:");
			vectorTecnico[tecnicosIngresados].nombre=In.readString();
			System.out.println("Apellido:");
			vectorTecnico[tecnicosIngresados].apellido=In.readString();
			tecnicosIngresados++;
			cantidadTecnicos--;
		}while (cantidadTecnicos != 0);

		System.out.println("¿Cuantos registros piensa guardar hoy?");
		int cantidadRegistros=In.readInt();
		Mantenimiento[] Registro=new Mantenimiento[cantidadRegistros];
		byte tecnicoDesignado;
		do{
			Registro[mantenimientosIngresados]=new Mantenimiento();
			System.out.println("Mantenimiento N°"+(mantenimientosIngresados+1));
			System.out.println("Elija el tecnico designado: ");
			tecnicoDesignado=In.readByte();
			Registro[mantenimientosIngresados].solucionador=vectorTecnico[(tecnicoDesignado-1)];
			System.out.println("Datos del cliente");
			Cliente Fulano=new Cliente();
			System.out.println("-----------------");
			System.out.println("Numero del cliente: ");
			Fulano.numeroCliente=In.readInt();
			System.out.println("Nombre: ");
			Fulano.nombre=In.readString();
			System.out.println("Apellido: ");
			Fulano.apellido=In.readString();
			System.out.println("Domicilio: ");
			Fulano.domicilio=In.readLine();
			Registro[mantenimientosIngresados].pagador=Fulano;//Guardo la instancia de la clase correspondiente dentro de la composicion del objeto debido a que si intento ingresar los datos directamente en los atributos de Registro[mantenimientosIngresados].pagador, entonces el programa se para y me aparece un "NullPointerException"
			System.out.println("Datos de la computadora");
			Computadora Ordenador=new Computadora();
			System.out.println("-----------------------");
			System.out.println("Marca: ");
			Ordenador.marca=In.readString();
			System.out.println("Modelo: ");
			Ordenador.modelo=In.readLine();
			System.out.println("Capacidad del disco duro: ");
			Ordenador.capacidadDiscoDuro=In.readLine();
			System.out.println("Memoria RAM: ");
			Ordenador.memoria=In.readLine();//Utilizando el metodo ReadLine() es posible que el programa lea cadwenas con espacios en blanco
			Registro[mantenimientosIngresados].pc=Ordenador;
			System.out.println("-----------------------");
			System.out.println("Importe: ");
			Registro[mantenimientosIngresados].importe=In.readDouble();
			System.out.println("Diagnostico, escriba un numero en base a la siguiente lista: ");
			System.out.println("1 - El equipo disminuyó su rendimiento");
			System.out.println("2 - Aparecen pantallas de error, los programas se tildan y se cierran");
			System.out.println("3 - La computadora se reinicia automáticamente o se apaga");
			System.out.println("4 - Ruidos extraños y vibraciones provenientes del gabinete de la CPU");
			System.out.println("5 - La página de inicio y/o el buscador del navegador se cambió solo");
			System.out.println("6 - El equipo no da video al encenderlo");
			System.out.println("7 - Las imágenes del monitor no tienen todos los colores");
			System.out.println("8 - Al encender la computadora aparece \"INSERT DISK BOOT AND RESTART\", \"NO SE ENCUENTRA EL SISTEMA OPERATIVO\" u \"OPERATING SYSTEM NOT FOUND. ROM HALTED\", etc.");
			System.out.println("9 - El puntero del mouse no se mueve");
			System.out.println("10 - El teclado no responde");
			System.out.println("11 - La unidad de cd-rom, grabadora de cd o dvd-rom no lee los cd´s");
			System.out.println("12 - La disquetera no lee los disquetes.");
			System.out.println("13 - La computadora no enciende");
			Registro[mantenimientosIngresados].diagnostico=In.readByte();
			mantenimientosIngresados++;
			cantidadRegistros--;
		}while (cantidadRegistros != 0);
		
		double importeTecnico3=0;
		for (int contador=0;contador < Registro.length;contador++)
		{
			if (Registro[contador].solucionador.nroTecnico == 3)
				{importeTecnico3+=Registro[contador].importe;}
		}
		System.out.println("El importe total del tecnico N°3 es de $"+importeTecnico3);
		
		double montosSuperioresA=0;
		System.out.println("Escriba un monto para mostrar los datos de los clientes que han efectuado un mantenimiento que tengan montos superiores a los escritos: ");
		montosSuperioresA=In.readDouble();
		for (int contador=0;contador < Registro.length;contador++)
		{
			if (Registro[contador].importe > montosSuperioresA)
				{System.out.println(Registro[contador].pagador.toString());}
		}
		
		int mantenimientoElegido=0;
		System.out.println("Escriba un numero de mantenimiento para mostrar los datos de los clientes y sus computadoras que han efectuado un mantenimiento: ");
		mantenimientoElegido=In.readInt();
		for (int contador=0;contador < Registro.length;contador++)
		{
			if (Registro[contador].numeroMantenimiento == mantenimientoElegido)
				{System.out.println(Registro[contador].pagador.toString());
				 System.out.println(Registro[contador].pc.toString());}
		}
	}

}

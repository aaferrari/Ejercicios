
public class Aplicacion {
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Empresa lugarLaboral=new Empresa();
		Empleado laborista=new Empleado();
		Consultor sujetoExterno=new Consultor();
		byte eleccion;
		byte empleadoConsultor;//Esta variable servira para determinar si el trabajador que se eligio cargar es un empleado o un onsultor
		
		System.out.println("Sistema de calculo de los sueldos de los empleados y consultores en una empresa\n");
		System.out.println("¿Como se llama la empresa?");
		lugarLaboral.razonSocial=In.readLine();
		System.out.println("Direccion:");
		lugarLaboral.direccion=In.readLine();
		int cantidadParaAgregar=0;
		do{
			System.out.println("¿Cuantos empleados hay en la empresa?");
			lugarLaboral.cantidadTrabajadores=In.readInt();
			if (lugarLaboral.cantidadTrabajadores < 1){System.out.println("Debe ingresarse al menos 1 trabajador");}
			else {cantidadParaAgregar=lugarLaboral.cantidadTrabajadores;}//Esto se usara luego como un contador que ura disminuyendo cada vez que se agregue un trabajador en el vector
		}while (lugarLaboral.cantidadTrabajadores < 1);
		lugarLaboral.trabajadores=new Trabajador[lugarLaboral.cantidadTrabajadores];
		int despachados;
		do{
			despachados=0;
			do{
			System.out.println("Elija una opcion:\n" +
					"0 - Salir del programa\n1 - Ingresar datos de trabajadores" +
					"\n2 - Mostrar el total a pagar de sueldos" +
					"\n3 - Mostrar el empleado y el consultor que gana menos y el que gana mas");
			eleccion=In.readByte();
			if (eleccion < 0 || eleccion > 3){System.out.println("Opcion incorrecta, intentelo nuevamente");}
			}while (eleccion < 0 || eleccion > 3);
			
			switch(eleccion){
			case 0:
				System.exit(0);
				break;
			case 1:
				do{
					do{
				System.out.println("Escriba 1 para ingresar datos un empleado habitual o 2 para ingresar a un consultor:");
				empleadoConsultor=In.readByte();
				if(empleadoConsultor!=1||empleadoConsultor!=2){System.out.println("Opcion incorrecta, intentelo nuevamente");}
					}while(empleadoConsultor!=1||empleadoConsultor!=2);
				System.out.println("Datos del trabajador N°"+(despachados+1)+"\n---------------------");
				System.out.println("Nombre: ");
				if (empleadoConsultor==1){laborista.nombre=In.readLine();}
				if (empleadoConsultor==2){sujetoExterno.nombre=In.readLine();}
				System.out.println("Fecha de nacimiento: ");
				if (empleadoConsultor==1){laborista.fechaNacimiento=In.readLine();}
				if (empleadoConsultor==2){sujetoExterno.fechaNacimiento=In.readLine();}
				System.out.println("DNI: ");
				if (empleadoConsultor==1){laborista.dni=In.readInt();}
				if (empleadoConsultor==2){sujetoExterno.dni=In.readInt();}
				System.out.println("Direccion: ");
				if (empleadoConsultor==1){laborista.direccion=In.readLine();}
				if (empleadoConsultor==2){sujetoExterno.direccion=In.readLine();}
				System.out.println("Telefono: ");
				if (empleadoConsultor==1){laborista.telefono=In.readLong();}
				if (empleadoConsultor==2){sujetoExterno.telefono=In.readLong();}
				System.out.println("Puesto de trabajo: ");
				if (empleadoConsultor==1){
					laborista.puesto=In.readLine();
					System.out.println("Salario bruto:");
					laborista.sueldo=In.readFloat();
					System.out.println("Impuestos cobrados:");
					laborista.impuestos= (3*laborista.sueldo)/100;
					lugarLaboral.trabajadores[despachados]=laborista;}
				if (empleadoConsultor==2){
					sujetoExterno.puesto=In.readLine();
					System.out.println("Cantidad de horas que trabaja:");
					sujetoExterno.horasTrabajadas=In.readInt();
					System.out.println("Tarifa:");
					sujetoExterno.tarifa=In.readFloat();
					lugarLaboral.trabajadores[despachados]=sujetoExterno;}
				System.out.println("\n"+lugarLaboral.trabajadores[despachados].toString());
				despachados++;
				cantidadParaAgregar--;
				}while (cantidadParaAgregar !=0);
				break;
			case 2:
				double totalSueldoNeto=0;//Uso el sueldo neto que proviene del metodo "calcularSueldo ya que si intento usar el sueldo bruto, entonces el IDE no me deja compilar el programa debido a que en la clase Trabajador no existen los atributos sueldo, impuestos o tarifas
				double sueldoEmpleado=0;
				double sueldoConsultor=0;
				for (int contador=0;contador<lugarLaboral.cantidadTrabajadores;contador++){
					totalSueldoNeto=totalSueldoNeto+lugarLaboral.trabajadores[contador].calcularSueldo();
					if(lugarLaboral.trabajadores[contador] instanceof Empleado){
						sueldoEmpleado=sueldoEmpleado+lugarLaboral.trabajadores[contador].calcularSueldo();
					}
					if(lugarLaboral.trabajadores[contador] instanceof Consultor){
						sueldoConsultor=sueldoConsultor+lugarLaboral.trabajadores[contador].calcularSueldo();
					}
				}
				System.out.println("Sueldo total neto: $"+totalSueldoNeto);
				System.out.println("Porcentaje que le corresponde a los empleados habituales: "+(sueldoEmpleado/totalSueldoNeto));
				System.out.println("Porcentaje que le corresponde a los consultores: "+(sueldoConsultor/totalSueldoNeto));
				break;
			case 3:
				Empleado empleadoMenorSueldo=null;
				Empleado empleadoMayorSueldo=null;
				Consultor consultorMayorTarifa=null;
				Consultor consultorMenorTarifa=null;
				for (int contador=0;contador<lugarLaboral.cantidadTrabajadores;contador++){
					if ((empleadoMenorSueldo==null||empleadoMenorSueldo.calcularSueldo() < lugarLaboral.trabajadores[contador].calcularSueldo()) && lugarLaboral.trabajadores[contador] instanceof Empleado){
						empleadoMenorSueldo=(Empleado) lugarLaboral.trabajadores[contador];}
					if ((empleadoMayorSueldo==null||empleadoMayorSueldo.calcularSueldo() > lugarLaboral.trabajadores[contador].calcularSueldo()) && lugarLaboral.trabajadores[contador] instanceof Empleado){
						empleadoMayorSueldo=(Empleado) lugarLaboral.trabajadores[contador];}
					if ((consultorMayorTarifa==null||consultorMayorTarifa.calcularSueldo() > lugarLaboral.trabajadores[contador].calcularSueldo()) && lugarLaboral.trabajadores[contador] instanceof Consultor){
						consultorMayorTarifa= (Consultor) lugarLaboral.trabajadores[contador];}
					if ((consultorMenorTarifa==null||consultorMenorTarifa.calcularSueldo() < lugarLaboral.trabajadores[contador].calcularSueldo()) && lugarLaboral.trabajadores[contador] instanceof Consultor){
						consultorMenorTarifa=(Consultor) lugarLaboral.trabajadores[contador];}

				}
				System.out.println("Datos del empleado que gana menos:\n"+empleadoMenorSueldo.toString());
				System.out.println("Datos del empleado que gana mas:\n"+empleadoMayorSueldo.toString());
				System.out.println("Datos del consultor que gana menos:\n"+consultorMenorTarifa.toString());
				System.out.println("Datos del consultor que gana mas:\n"+consultorMayorTarifa.toString());
				break;
			}
			//default:{System.out.println("No se ha elegido ninguna accion.")};
	}while (eleccion !=0);
	}
}


public class Mantenimiento {
	public int numeroMantenimiento;//Tiene que ser autonumerico, lo cual se logra mediante el metodo constructor incrementado +1
	public Cliente pagador;
	public Computadora pc;
	public Tecnico solucionador;
	public byte diagnostico;
	public double importe;

	public void setNumeroMantenimiento(int valor){numeroMantenimiento=valor;}
	public void setPagador (Cliente valor){pagador=valor;}
	public void setPC(Computadora valor){pc=valor;}
	public void setSolucionador(Tecnico valor){solucionador=valor;}
	public void setDiagnostico(byte valor){diagnostico=valor;}
	public void setImporte(double valor){importe=valor;}

	public int getNumeroMantenimiento(){return numeroMantenimiento;}
	public Cliente getPagador (){return pagador;}
	public Computadora getPC(){return pc;}
	public Tecnico getSolucionador(){return solucionador;}
	public byte getDiagnostico(){return diagnostico;}
	public double getImporte(){return importe;}

	public String Diagnosticador()
	{switch(diagnostico){
		case 1: return "El equipo disminuyó su rendimiento";
		case 2: return "Aparecen pantallas de error, los programas se tildan y se cierran";
		case 3: return "La computadora se reinicia automáticamente o se apaga";
		case 4: return "Ruidos extraños y vibraciones provenientes del gabinete de la CPU";
		case 5: return "La página de inicio y/o el buscador del navegador se cambió solo";
		case 6: return "El equipo no da video al encenderlo";
		case 7: return "Las imágenes del monitor no tienen todos los colores";
		case 8: return "Al encender la computadora aparece \"INSERT DISK BOOT AND RESTART\", \"NO SE ENCUENTRA EL SISTEMA OPERATIVO\" u \"OPERATING SYSTEM NOT FOUND. ROM HALTED\", etc.";
		case 9: return "El puntero del mouse no se mueve";
		case 10: return "El teclado no responde";
		case 11: return "La unidad de cd-rom, grabadora de cd o dvd-rom no lee los cd´s";
		case 12: return "La disquetera no lee los disquetes.";
		case 13: return "La computadora no enciende";
		default: return "Diagnostico desconocido";
		}
	}

	public String toString(){return "Numero de mantenimiento: "+numeroMantenimiento+
		"\n"+pagador.toString()+"\n"+pc.toString()+"\n"+solucionador.toString()
		+"\n"+Diagnosticador()+"\nEl importe a cobrar es de $"+importe;
	}

	public Mantenimiento()
	{
		numeroMantenimiento=0;
		pagador=null;
		pc=null;
		solucionador=null;
		diagnostico=0;
		importe=0;
		numeroMantenimiento++;
	}
}

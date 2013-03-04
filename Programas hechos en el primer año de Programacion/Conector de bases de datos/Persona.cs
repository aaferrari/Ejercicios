using System;
using System.Collections.Generic;
using System.Text;

namespace Conector_de_bases_de_datos
{
   public class Persona
    {
        string apellido;
        string nombres;
        byte tipo_documento;
        int nro_documento;
        byte estado_civil;
        byte sexo;
        bool falecimiento;

       public string Apellido
       {
           set { apellido = value; }
           get { return apellido; }
       }

       public string Nombres
       {
           set { nombres = value; }
           get { return nombres; }
       }

       public byte TipoDocumento
       {
           set { tipo_documento = value; }
           get { return tipo_documento; }
       }

       public int NroDocumento
       {
           set { nro_documento = value; }
           get { return nro_documento; }
       }

       public byte EstadoCivil
       {
           set { estado_civil = value; }
           get { return estado_civil; }
       }

       public byte Sexo
       {
           set { sexo = value; }
           get { return sexo; }
       }

       public bool Fallecimiento
       {
           set { falecimiento = value; }
           get { return falecimiento; }
       }
       
       public string MostradorDeDocumentos()
       	{switch (tipo_documento)
       	{case 4 :{return "Cedulon Federal";}
       			case 2 :{return "Libreta de enrolamiento";}
       			case 3 :{return "Libreta de yo que se";}
       			case 5 :{return "Pasaporte";}
       			case 6 :{return "Sin determinar";}
       			default: {return "DNI";}
       		 }
       	}
       
       public string EstadoCivico()
       	{if (sexo == 1)
       		{switch (estado_civil)
       		{	case 2 :{return "Casado";}
       				case 4: {return "Separado";}
       				case 3: {return "Viudo";}
       				default: {return "Soltero";}
       		 }
       		}
       	else
       		{switch (estado_civil)
       		{case 2 :{return "Casada";}
       		case 4: {return "Separada";}
       		case 3: {return "Viuda";}
       		default: {return "Soltera";}
       		 }
       		}
       		
       	}
       
       public string Sexualizador()
       {if (sexo == 1)
       		{return "Hombre";}
       	else
       		{return "Mujer";}
       }
       
       public string MuertoONo()
       {if (falecimiento == true)
       		{return "Muerto";}
       	else
       		{return "Vivo";}
       	}

       public string toString()
       {return apellido + ";" + nombres + ";" + MostradorDeDocumentos() + ";" + nro_documento + ";" + EstadoCivico() + ";" + Sexualizador() + ";" + MuertoONo(); }
       
       public Persona()
       {
           apellido = "";
           nombres = "";
           tipo_documento = 0;
           nro_documento = 0;
           estado_civil = 0;
           sexo = 0;
           falecimiento = false;
       }

    }
}

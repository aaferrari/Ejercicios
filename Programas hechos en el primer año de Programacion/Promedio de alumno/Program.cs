using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication1
/*{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno1 Fulano1, Fulano2;
            Fulano1= new Alumno1();
            Fulano1.pLegajo=685675;
            Fulano1.pNombre="Fulano de tal";
            Fulano1.pNota1=2;
            Fulano1.pNota2=7;
            Console.ReadLine();
            Console.WriteLine("A continuacion se muestran los datos del promer alumno");
            Console.WriteLine("====================================================== ");
            Console.WriteLine(Fulano1.toString());
            Console.ReadLine();
            cronometro.Stop();
            Fulano2 = new Alumno1(837347, "Menganito", 6, 7);

            Console.WriteLine("A continuacion se muestran los datos del segundo alumno y despues al hacer enter, el programa se cierra");
            Console.WriteLine("====================================================== ");
           Console.WriteLine(Fulano2.toString());
           Console.WriteLine(Convert.ToString(cronometro.Elapsed));
           Console.ReadLine();
        }

      
    }
}*/
	
{
    class Program
    {
               public static string EB_String(ulong entero)
		{
   	 	//La máscara y el # de iteraciones
    		const ulong mascara = 0x8000000000000000;
    		const int iteraciones = 64;
    		//el contador y el resultado
    		int contador = 0;
    		string resultado = "";
 
    		//Se recorren los 32 bit
   		 while (contador++ < iteraciones)
    			{
       			 /*Si el entero and la mascara = 0 quiere decir
         		*que el bit 1 esta apagado*/
        		if ((entero & mascara) == 0)
          		  resultado += "0";
       			 else
         		   resultado += "1";
 
        		/*correr un bit a la izquierda para poner
        		 *el siguiente bit en la posicion del primero*/
        		entero = entero << 1;
    			}
   		 return resultado;
		}
		
	public static string EB_StringBuilder(ulong entero)
		{
 		   //La máscara y el # de iteraciones
		    const ulong mascara = 0x8000000000000000;
		    const int iteraciones = 64;
		    //el contador y el resultado
		    int contador = 0;
		    StringBuilder resultado = new StringBuilder(iteraciones);
 
 		   //Se recorren los 32 bit
		    while (contador++ < iteraciones)
		    {
		        /*Si el entero and la mascara = 0 quiere decir
		         *que el bit 1 esta apagado*/
		        if ((entero & mascara) == 0)
		            resultado.Append('0');
		        else
		            resultado.Append('1');
 
		        /*correr un bit a la izquierda para poner
		         *el siguiente bit en la posicion del primero*/
		        entero = entero << 1;
		    }
		    return resultado.ToString();
		}
		
	public static unsafe string EB_Unsafe(ulong entero)
		{
		    const ulong mascara = 0x8000000000000000;
		    const int iteraciones = 64;
 
		    int contador = 0;
 
		    //Se reservan 32 posiciones y uno adicional para 
		    //terminacion en null
		    char* resultado = stackalloc char[iteraciones + 1];
		    //puntero de trabajo
		    char* aux = resultado;
 
		    while (contador++ < iteraciones)
		    {
		        if ((entero & mascara) == 0)
		            *aux = '0';
		        else
		            *aux = '1';
 
		        //Mover el puntero una posicion dentro de la cadena
		        aux++;
 
		        entero = entero << 1;
		    }
		    return new string(resultado);
		}

	public static unsafe string EB_Unsafe_Opt(ulong entero)
		{
		    const ulong mascara = 0x1;
		    const int iteraciones = 64;
 
		    char* resultado = stackalloc char[iteraciones + 1];
		    char* aux = resultado + iteraciones - 1;
 
		    do
		    {
		        if ((entero & mascara) == 0)
		            *(aux--) = '0';
		        else
		            *(aux--) = '1';
 
		        entero = entero >> 1;
		    } while (entero != 0);
 
		    return new string(++aux);
		}
	//-----------------------------------------------
	public static string Bisiesto1(long año)
		{
   	 	if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
   	 			return ("El año"+ año+" es bisiesto");
            }
 
            else
            {
                return ("El año"+ año+"no es bisiesto");
            }

		}
		
	public static string Bisiesto2(long año)
		{
 		   long moduloCuatro = 0;
            long moduloCien = 0;
            long moduloCuatroCien = 0;
            string salida = "";
            moduloCuatro = año %4;
            moduloCien = año %100;
            moduloCuatroCien = año % 400;
            salida = "El año " + año ;

			if (moduloCuatro==0)
            {
                if (moduloCien==0)
                {
                    if (moduloCuatroCien == 0)
                    {
                        salida += " es Bisiesto";
                    }
                    else
                    {
                        salida += " no es Bisiesto";
                    }
                }
                else
                {
                    salida += " es Bisiesto";
               }
            }
            else
            {
                salida += " no es Bisiesto";
            }
		return salida;
		}
		
	public static bool EsBisiesto1(long anno)
		{
		   bool resultado;
		   //Comprobamos la regla general.
		   //Si anno es divisible por 4, es decir, si el
		   //resto de la división entre 4 es 0...
		   if (anno % 4 == 0)
		   {
 		     //Si es divisible por 4, ahora toca comprobar
		      //la excepción
  		    if (
   		        (anno % 100 == 0) &&  //Si es divisible por 100
   		        (anno % 400 != 0)     //y no por 400
     		    )
     		    {
             resultado = false; //entonces no es bisiesto
         		}
        	 else
         {
            resultado = true; //No cumple la excepción.
            //Lo dejamos como bisiesto por ser divisible por 4
         }
      }
      else //Si no cumple la regla general
      {
         //No es bisiesto.
         resultado = false;
      }
      return resultado;
} //EsBisiesto

	public static bool EsBisiesto2(long anno)
   {
     //devuelve true si el año es múltiplo de 4 y
     //no es multiplo de 100 pero no de 400
     //false en caso contrario
     return (anno % 4 == 0) && !(anno % 100 == 0 && anno % 400 != 0);
   }

	public static bool EsBisiesto3(long anno)
   {
      return ((anno % 4 == 0 && anno % 100 != 0) || anno % 400 == 0);
   }


        static void Main(string[] args)
        {
        	Random NAleatorio1=new Random(DateTime.Now.Millisecond);//Metodo sacado de http://www.subgurim.net/Articulos/csharp/94/random-numeros-aleatorios.aspx
        	Random NAleatorio2=new Random(DateTime.Now.Millisecond);//Es mejor crear el objeto aqui en vez de hacerlo en el for debido a que es muy probable que utilice el mismo numero varias veces antes de pasar a otro
        	Random NAleatorio3=new Random(DateTime.Now.Millisecond);
            Stopwatch cronometro;
            ulong numero=0;
            string producto="";
            decimal tiempo1=0;
            decimal tiempo2=0;
            decimal tiempo3=0;
            decimal tiempo4=0;
           // decimal tiempo5=0;
            int veces=0;
            
            Console.WriteLine("Probador de codigo multiproposito (en consola)");
            Console.WriteLine();
            Console.WriteLine("ingrese el numero de veces que quiere que el programa haga las pruebas:");
            veces=Int32.Parse(Console.ReadLine());
            for (int entero=veces;entero !=0;entero--)
            {
         //Procesando datos
	    
	    
         numero=Convert.ToUInt64(Convert.ToString(NAleatorio1.Next(0,1844674407))+Convert.ToString(NAleatorio2.Next(0,370955161)+Convert.ToString(NAleatorio3.Next(0,5))));
	    Console.WriteLine("El numero aleatorio a usar es "+numero);
	    cronometro=new Stopwatch();
	    cronometro.Start();
	    EB_String(numero);
	    //Bisiesto1(numero);//producto=
	    cronometro.Stop();
	    tiempo1=tiempo1+ Convert.ToDecimal(Convert.ToString(cronometro.Elapsed).Substring(7,9));
          /* Console.WriteLine("Primer metodo");
            Console.WriteLine("-------------");
            Console.WriteLine("El resultado es: "+producto);
            Console.WriteLine("El tiempo que este metodo tardo en ejecutarse fue de "+Convert.ToString(cronometro.Elapsed)+" \ny en decimales seria "+tiempo1);
            Console.WriteLine(); */
            
            cronometro=new Stopwatch();
            cronometro.Start();
             EB_StringBuilder(numero);//producto=Bisiesto2(numero);
	     cronometro.Stop();
	     tiempo2=tiempo2+ Convert.ToDecimal(Convert.ToString(cronometro.Elapsed).Substring(7,9));
           /* Console.WriteLine("Segundo metodo");
            Console.WriteLine("--------------");
            Console.WriteLine("El resultado es: "+producto);
            Console.WriteLine("El tiempo que este metodo tardo en ejecutarse fue de "+Convert.ToString(cronometro.Elapsed));
            Console.WriteLine(); */
            
            cronometro=new Stopwatch();
            cronometro.Start();
            EB_Unsafe(numero);//producto=EsBisiesto1(numero)
	     cronometro.Stop();
	     tiempo3=tiempo3+ Convert.ToDecimal(Convert.ToString(cronometro.Elapsed).Substring(7,9));
          /* Console.WriteLine("Tercer metodo");
            Console.WriteLine("-------------");
            Console.WriteLine("El resultado es: "+producto);
            Console.WriteLine("El tiempo que este metodo tardo en ejecutarse fue de "+Convert.ToString(cronometro.Elapsed));
            Console.WriteLine(); */
            
            cronometro=new Stopwatch();
            cronometro.Start();
            EB_Unsafe_Opt(numero);//producto=EsBisiesto2(numero);
	      cronometro.Stop();
	      tiempo4=tiempo4+ Convert.ToDecimal(Convert.ToString(cronometro.Elapsed).Substring(7,9));
            }
	      /*
            Console.WriteLine("Cuarto metodo");
            Console.WriteLine("-------------");
            Console.WriteLine("El resultado es: "+producto);
            Console.WriteLine("El tiempo que este metodo tardo en ejecutarse fue de "+Convert.ToString(cronometro.Elapsed));
            Console.WriteLine();*/
           
            /*cronometro=new Stopwatch();
            cronometro.Start();
            EsBisiesto3(numero); //producto=System.Convert.ToString(numero, 2)
	     cronometro.Stop();
	     	tiempo5=tiempo5+ Convert.ToDecimal(Convert.ToString(cronometro.Elapsed).Substring(7,9));
            Console.WriteLine("Quinto metodo");
            Console.WriteLine("-------------");
            Console.WriteLine("El resultado es: "+producto);
            Console.WriteLine("El tiempo que este metodo tardo en ejecutarse fue de "+Convert.ToString(cronometro.Elapsed));
   		Console.WriteLine();*/
           Console.WriteLine("El tiempo promedio de la 1° funcion es de: "+(tiempo1/veces));
           Console.WriteLine("El tiempo promedio de la 2° funcion es de: "+(tiempo2/veces));
           Console.WriteLine("El tiempo promedio de la 3° funcion es de: "+(tiempo3/veces));
           Console.WriteLine("El tiempo promedio de la 4° funcion es de: "+(tiempo4/veces));
	// Console.WriteLine("El tiempo promedio de la 5° funcion es de: "+(tiempo5/veces));
           Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Fin, presione enter para salir");
            Console.ReadLine();
        }
    }
}

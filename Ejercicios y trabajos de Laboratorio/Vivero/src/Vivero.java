public class Vivero
{//Atributos
private String razonSocial;
private String direccion;
private Planta planta[];
//Constructor sin Argumentos.
public Vivero()
{
	razonSocial="";
	direccion="";
	planta=new Planta[20];
}
//Constructor con Argumentos
public Vivero(String r,String d,int n)
{ 
	razonSocial=r;
	direccion=d;
	planta=new Planta[n];
	for(int i=0;i<n;i++)//inicializa el vector planta
		planta[i]=null;
}
public String getRazon(){return razonSocial;}
public String getDir(){return direccion;}
//método permite mostrar una componente del arreglo
public Planta getPlanta(int indice)
{ return planta[indice];//muestra todos los datos del componente
}
public void setRazon(String r){ razonSocial=r;}
public void setDir(String d){ direccion=direccion;}
//método permite cargar un componente del arreglo.
public void setPlanta(int indice,Planta pl){ planta[indice]=pl;}

public String toString()
{ String auxiliar;
auxiliar=razonSocial+" "+direccion + "Plantas: ";
for(int i=0;i<planta.length;i++)
	auxiliar+= planta[i].toString() + " ";
return auxiliar;
}

//Metodos de control.
public float TotalStock()
{ float acumulador=0;
for(int i=0;i<planta.length;i++)
	acumulador=acumulador+planta[i].getCantidad();
return acumulador;
}
public String StockMinimo()
{ String aux="";
for(int i=0;i<planta.length;i++)
if(planta[i].getCantidad()<planta[i].getStock())
aux+=" ;" + planta[i].toString();
return aux;
}
public String PlantaxTipo()
{ String aux;
int c1,c2,c3;
c1=c2=c3=0;
for(int i=0;i<planta.length;i++)
{ switch(planta[i].getTipo())
{ case 1: c1++;
break;
case 2: c2++;
break;
case 3: c3++;
break;
}
}
aux="La cantidad de planta1 es:" + c1 + "Tipo2:"+c2 +" Tipo3:" + c3;
return aux;
}
//Planta mayor stock posee
public String MayorStock()
{ int may=0;
int indice=0;
for(int i=0;i<planta.length;i++)
{ if(i==0)
{may=planta[i].getStock();
indice=i;}
else
{ if(planta[i].getStock()>may)
{ may=planta[i].getStock();
indice=i;}
}
}
return planta[indice].toString();
}
}
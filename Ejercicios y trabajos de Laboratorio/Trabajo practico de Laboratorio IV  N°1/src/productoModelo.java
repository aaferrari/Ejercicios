import java.sql.ResultSet;
import java.util.Vector;

public class productoModelo {
	Conexion enlace;
	Producto cosa;
	ResultSet resultado;

	public void Insertador(Producto instanciacion) throws Exception
	{
		this.Ejecutador("insert into Producto (nombre,marca,precio) values ('"+instanciacion.getNombre()+"',"+instanciacion.getIdMarca()+","+instanciacion.getPrecio()+")");
	}

	public void Eliminador(int identificador) throws Exception
	{
		this.Ejecutador("delete from Producto where codigo ="+identificador);
	}

	public Producto SeleccionadorUnitario(int identificador) throws Exception//Esto se usara para elegir un producto existente para ser modificado o eliminado de la base de datos
		{
			resultado=this.traeConsultas("select * from producto where codigo="+identificador);
			cosa=new Producto();
			while (resultado.next() == true)
			{
				cosa.setCodigo(resultado.getInt("codigo"));
				cosa.setIdMarca(resultado.getInt("marca"));
				cosa.setNombre(resultado.getString("nombre"));
				cosa.setPrecio(resultado.getFloat("precio"));
			}
			enlace.desconectar();
			return cosa;
		}


	public Vector Buscador(String marcaParaBuscar,String textoParaBuscar,String disyuntivo) throws Exception
	{
		resultado=this.traeConsultas("select codigo,marca.nombre as descripcionMarca,producto.nombre as Descripcion,precio,marca from producto inner join marca on producto.marca=marca.id where producto.nombre like '%"+textoParaBuscar+"%' "+disyuntivo+" marca like '%"+marcaParaBuscar+"%'");
		Vector<Producto> listaDeResultados= new Vector<Producto>();
		while (resultado.next() == true)
		{
			cosa=new Producto();
			cosa.setCodigo(resultado.getInt("codigo"));
			cosa.setMarca(resultado.getString("descripcionMarca"));
			cosa.setNombre(resultado.getString("Descripcion"));
			cosa.setPrecio(resultado.getFloat("precio"));
			//cosa.setIdMarca(resultado.getInt("marca"));
			listaDeResultados.add(cosa);
		}
		enlace.desconectar();
		return listaDeResultados;
	}

	public void Modificador(Producto instanciacion) throws Exception
	{
		this.Ejecutador("update producto set nombre='"+instanciacion.getNombre()+"', marca="+instanciacion.getIdMarca()+", precio="+instanciacion.getPrecio()+" where codigo="+instanciacion.getCodigo());
	}
	
	public ResultSet llenadorDeComboBoxDeMarca() throws Exception
	{
		resultado=this.traeConsultas("select nombre from marca");
		return resultado;
	}

	public void Ejecutador(String sentencia) throws Exception
	{
		enlace.conectar("sqlite","productos.db");
		enlace.ejecutar(sentencia);
		enlace.desconectar();
	}
	
	public ResultSet traeConsultas(String sentenciaConsulta) throws Exception
	{
		enlace=new Conexion();
		enlace.conectar("sqlite","productos.db");
		ResultSet resultado=enlace.consultar(sentenciaConsulta);
		return resultado;
	}
}

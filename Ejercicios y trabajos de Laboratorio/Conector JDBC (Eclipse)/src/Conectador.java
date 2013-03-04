/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

import java.sql.*;
/**
 *
 * @author alumno
 */
public class Conectador {
    Connection conexion;
	Statement Sentencia;
	ResultSet resultadosConsulta;

	public void abrirConexion() {
		try {
/*			String Usuario = "alumno1w1";
			String Contrasenia = "alumno1w1";
			String url = "jdbc:sqlserver://SNOWBALL;DATABASENAME=DatosCoches";
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver").newInstance(); */
			String url = "jdbc:sqlserver://SNOWBALL;DATABASENAME=DatosCoches";
			Class.forName("org.sqlite.JDBC").newInstance();
			conexion = DriverManager.getConnection(url, Usuario, Contrasenia);
			System.out.println("Conexion a la BD");
		} catch (Exception e) {
			System.out.println("Error en conexión. A continuacion se muestra el mensaje de error para que lo evalue su proveedor: "+e.toString());
		}
	} // Para cerrar la conexión una vez terminadas las consultas

	public void cerrarConexion() {
		try {
			conexion.close();
			System.out.println("Conexión cerrada");
		} catch (SQLException e) {
			System.out.println("Error al cerrar conexión. A continuacion se muestra el mensaje de error para que lo evalue su proveedor: "+e.toString());

		}
	}

    public void mostrarDatosCoches() {
		try {
			while (resultadosConsulta.next()) {
				String matriculaEncadenada = resultadosConsulta.getString("Matricula");
				String marcaEncadenada = resultadosConsulta.getString("Marca");
				int precioConvertido = resultadosConsulta.getInt("Precio");
        		System.out.println(matriculaEncadenada + "\t|" + marcaEncadenada + "\t|" + precioConvertido);
			}
		} catch (Exception e) {
			System.out.println("Error al visualizar datos");
		}
	}
    // Método para modificar la tabla Coches pasando la matrícula del coche
	// que se quiere modificar y el nuevo precio. Las cadenas en la
	// condición es necesario ponerlas entre comillas simples.
    public void modificador(String matricula, int precioModificado) {
		try {
			Sentencia = conexion.createStatement();
			Sentencia.executeUpdate("Update Coches set Precio=" + precioModificado + " where Matricula like '" + matricula + "%'");
			System.out.println("Registro modificado correctamente");
		} catch (SQLException e) {
			System.out.println("Error al modificar");
		}
	}

	// Método para borrar el coche cuya matricula se pasa como argumento
	public void borrador(String matricula) {
		try {
			Sentencia = conexion.createStatement();
			Sentencia.executeUpdate("DELETE FROM Coches where Matricula like '" + matricula + "%'");
			System.out.println("Elemento Borrado");
		} catch (SQLException e) {
			System.out.println("Error al Borrar");
		}
	}

	// Método que permite insertar un nuevo registro en la tabla Coches,
	// pasándole como argumento la matrícula, marca, precio del coche y
	// dni del propietario
	public void insertador(String matriculaNueva, String marcaNueva, int precioNuevo, String dniPropietario) {
		try {
			Sentencia = conexion.createStatement();
			Sentencia.executeUpdate("INSERT INTO Coches (Matricula,Marca,Precio,DNI) values ('" + matriculaNueva + "', '" + marcaNueva + "'," + precioNuevo + ",'" + dniPropietario + "')");
			System.out.println("El nuevo coche se guardo exitosamenet");
		} catch (SQLException e) {
			System.out.println("Error al insertar. A continuacion se muestra el mensaje de error para que lo evalue su proveedor: "+e.toString());
		}
	}

    	public void estructuradorTabla(String tabla) {
		try {
			Sentencia = conexion.createStatement();
			resultadosConsulta = Sentencia.executeQuery("Select * from " + tabla);
			// Obtiene el metadata del ResultSet
			ResultSetMetaData metadatosRegistros = resultadosConsulta.getMetaData();
			// Obtiene la cantidad de columnas del ResultSet
			int col = metadatosRegistros.getColumnCount();
			for (int contador = 1; contador <= col; contador++) {
				System.out.println("Campo " +
				// Devuelve el nombre del campo i
						metadatosRegistros.getColumnLabel(contador) + "\t"
						// Devuelve el tipo del campo i
						+ "Tipo: " + metadatosRegistros.getColumnTypeName(contador));
			}
		} catch (Exception e) {
			System.out.println("Error en Metadata ");
		}
	}
        public void infoBaseDeDatos() throws SQLException {
		DatabaseMetaData metadatosDeBaseDeDatos = conexion.getMetaData();
		if (metadatosDeBaseDeDatos == null)
			System.out.println("No hay información de MetaData");
		else {
			System.out.println("Tipo de la BD: " + metadatosDeBaseDeDatos.getDatabaseProductName());
			System.out.println("Versión : " + metadatosDeBaseDeDatos.getDatabaseProductVersion());
			System.out.println("Cantidad máxima de conexiones activas: " + metadatosDeBaseDeDatos.getMaxConnections());
// Esta linea se comento ya que tira una excepcion "AbstractMethodError"    System.out.println("Informacion y propiedades del cliente: " + metadatosDeBaseDeDatos.getClientInfoProperties());
		}
	}

    public void obtenerDatosTabla() {
		try {
			Sentencia = conexion.createStatement();
			resultadosConsulta = Sentencia.executeQuery("SELECT * FROM Coches ORDER BY precio DESC");
			System.out.println("Tabla abierta");
		} catch (SQLException e) {
			System.out.println("Error al Abrir tabla ");
		}
	}

}

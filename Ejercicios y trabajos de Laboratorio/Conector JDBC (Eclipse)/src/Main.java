/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

import java.sql.*;


/**
 *
 * @author alumno
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws SQLException {
		Conectador consultasEInconsultas = new Conectador();
		consultasEInconsultas.abrirConexion();
		consultasEInconsultas.obtenerDatosTabla();
		consultasEInconsultas.mostrarDatosCoches();
		consultasEInconsultas.modificador("BA-3333", 5000);
		consultasEInconsultas.borrador("MA");
		consultasEInconsultas.insertador("ABC-666", "Pirulo", 56748573, "746");
		//consultasEInconsultas.insertar2("X25", "Jose", 54);
		consultasEInconsultas.infoBaseDeDatos();
		consultasEInconsultas.estructuradorTabla("Propietarios");
//		consultasEInconsultas.verCualquierTabla("Coches");
		consultasEInconsultas.cerrarConexion();
	}


}

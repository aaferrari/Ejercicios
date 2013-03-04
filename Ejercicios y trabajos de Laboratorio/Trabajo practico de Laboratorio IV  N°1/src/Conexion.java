import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class Conexion {
	Connection con;
	Statement st;
	public void conectar(String tipoBaseDatos,String baseDatos) throws Exception {
		Class.forName("org.sqlite.JDBC");
		con = DriverManager.getConnection("jdbc:"+tipoBaseDatos+":"+baseDatos);
		st=con.createStatement();
	}

	public ResultSet consultar(String sql) throws Exception{
		return st.executeQuery(sql);
	}

	public int  ejecutar(String sql) throws Exception{
		return st.executeUpdate(sql);
	}

	public void desconectar() throws Exception  {
		st.close();
		con.close();
	}
}

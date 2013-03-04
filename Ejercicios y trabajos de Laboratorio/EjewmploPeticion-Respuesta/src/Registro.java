

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class for Servlet: Registro
 *
 */
 public class Registro extends javax.servlet.http.HttpServlet implements javax.servlet.Servlet {
   static final long serialVersionUID = 1L;
   static final  String  PARAMETRO_NOMBRE  =  "Nombre" ; 
   static final  String  PARAMETRO_CORREO  =  "Correo" ; 

    /* (non-Java-doc)
	 * @see javax.servlet.http.HttpServlet#HttpServlet()
	 */
	public Registro() {
		super();
	} 
	
	/* (non-Javadoc)
	 * @see javax.servlet.Servlet#destroy()
	 */
	public void destroy() {
		// TODO Auto-generated method stub
		super.destroy();
	}   	
	
	/* (non-Java-doc)
	 * @see javax.servlet.http.HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}  	
	
	/* (non-Java-doc)
	 * @see javax.servlet.http.HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest peticion, HttpServletResponse respuesta) throws ServletException, IOException {
		respuesta.setContentType( "text/html" ); 
		java.io.PrintWriter salida=respuesta.getWriter(); 
		  
		 // Leer los parámetros de la petición  
		String nombre_usuario = peticion.getParameter( PARAMETRO_NOMBRE ); 
		String correo = peticion.getParameter( PARAMETRO_CORREO ); 
		 
		 // Mandar página de respuesta  
		salida.println( "<html><head><title>Registro</title></head>" ); 
		salida.println( "<body>Datos del cliente "  ); 
		salida.println( "<h2>Nombre: " +nombre_usuario+ "</h2>" ); 
		salida.println( "<h2>Correo: " +correo+ "</h2>" ); 
		salida.println( "</body></html>" ); 
		salida.close();  // indica al servidor que se ha terminado de  
		  // mandar la información  

	}   	  	  
	
	/* (non-Javadoc)
	 * @see javax.servlet.GenericServlet#init()
	 */
	public void init() throws ServletException {
		// TODO Auto-generated method stub
		super.init();
	}   
	
	/* (non-Javadoc)
	 * @see java.lang.Object#toString()
	 */
	public String toString() {
		// TODO Auto-generated method stub
		return super.toString();
	} 
}
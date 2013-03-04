public class Producto {
	private int codigo;
	private String nombre;
	private String marca;
	private float precio;
	private int idMarca;//Agrego este atributo para poder formar la relacion entre la tabla producto y la tabla marca
	public Producto() {
		super();
		codigo = 0;
		nombre = "";
		marca = "";
		precio = 0;
		idMarca=0;
	}
	public Producto(int codigo, String nombre, String marca, float precio, int idMarca) {
		super();
		this.codigo = codigo;
		this.nombre = nombre;
		this.marca = marca;
		this.precio = precio;
		this.idMarca=idMarca;
	}
	/**
	 * @return the codigo
	 */
	public int getCodigo() {
		return codigo;
	}
	/**
	 * @param codigo the codigo to set
	 */
	public void setCodigo(int codigo) {
		this.codigo = codigo;
	}
	/**
	 * @return the marca
	 */
	public String getMarca() {
		return marca;
	}
	/**
	 * @param marca the marca to set
	 */
	public void setMarca(String marca) {
		this.marca = marca;
	}
	/**
	 * @return the nombre
	 */
	public String getNombre() {
		return nombre;
	}
	/**
	 * @param nombre the nombre to set
	 */
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	/**
	 * @return the precio
	 */
	public float getPrecio() {
		return precio;
	}
	/**
	 * @param precio the precio to set
	 */
	public void setPrecio(float precio) {
		this.precio = precio;
	}
	
	/**
	 * @return the idMarca
	 */
	public int getIdMarca() {
		return idMarca;
	}
	/**
	 * @param idMarca the idMarca to set
	 */
	public void setIdMarca(int idMarca) {
		this.idMarca = idMarca;
	}
	
	public String toString() {
		String aux = "";
		aux = "\n Código: "+codigo+", Nombre: "+nombre+", Marca: "+marca+", Precio: $"+precio;
		return aux;
	}
	
}

import javax.swing.DefaultListModel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JLabel;
import java.awt.GridBagConstraints;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;

//import Producto;

import java.awt.Rectangle;
import java.awt.Point;
import java.sql.ResultSet;
import java.util.Vector;
import javax.swing.JList;


/**
* This code was edited or generated using CloudGarden's Jigloo
* SWT/Swing GUI Builder, which is free for non-commercial
* use. If Jigloo is being used commercially (ie, by a corporation,
* company or business for any purpose whatever) then you
* should purchase a license for each developer using Jigloo.
* Please visit www.cloudgarden.com for details.
* Use of Jigloo implies acceptance of these licensing terms.
* A COMMERCIAL LICENSE HAS NOT BEEN PURCHASED FOR
* THIS MACHINE, SO JIGLOO OR THIS CODE CANNOT BE USED
* LEGALLY FOR ANY CORPORATE OR COMMERCIAL PURPOSE.
*/
public class ABMProducto extends JFrame {

	productoModelo ModeladorProductario=new productoModelo();
	private JLabel jLabel4;
	private JLabel jLabel5;
	private JButton btnActualizar;
	private JComboBox CmbMarcaABuscar;
	private JRadioButton jRBor;
	private JTextField txtNombreABuscar;
	private static final long serialVersionUID = 1L;

	private JPanel jContentPane = null;

	private JRadioButton jRBand;
	private JComboBox cmbMarca;

	private JTextField txtCodigo = null;

	private JLabel jLabel1 = null;

	private JLabel jLabel2 = null;

	private JLabel jLabel3 = null;

	private JTextField txtNombre = null;

	private JTextField txtPrecio = null;
	private JScrollPane SPnPanelDeDesplazadmiento;

	private JButton btnAceptar = null;

	private JButton btnCancelar = null;
	
	private JList lstProductos = null;

	private JButton btnEliminar = null;

	private DefaultListModel listModel = null;
	public Vector<Producto> listaProductos=null;
	public Producto productoPuro;
	private JButton btnBuscar = null;
	/**
	 * This is the default constructor
	 * @throws Exception 
	 */
	public ABMProducto() {
		super();
		initialize();
		listModel = new DefaultListModel();
	}

	/**
	 * This method initializes this
	 * 
	 * @return void
	 * @throws Exception 
	 */
	private void initialize() {
		this.setSize(812, 272);
		this.setTitle("Cargar producto");
		this.setContentPane(getJContentPane());
		try {cargadorDeProductos(false);} 
		catch (Exception ExcepcionGeneral) {ExcepcionGeneral.printStackTrace();}
		txtCodigo.setVisible(false);//Ocultamos el txtCodigo debido a que no hara falta ser editado
	}

	/**
	 * This method initializes jContentPane
	 * 
	 * @return javax.swing.JPanel
	 */
	private JPanel getJContentPane() {
		if (jContentPane == null) {
			GridBagConstraints gridBagConstraints8 = new GridBagConstraints();
			gridBagConstraints8.gridx = 1;
			gridBagConstraints8.gridy = 4;
			jLabel3 = new JLabel();
			jLabel3.setText("Precio: $");
			jLabel3.setBounds(373, 67, 51, 16);
			jLabel2 = new JLabel();
			jLabel2.setText("Marca:");
			jLabel2.setBounds(373, 38, 42, 16);
			jLabel1 = new JLabel();
			jLabel1.setText("Nombre:");
			jLabel1.setBounds(373, 17, 51, 16);
			jContentPane = new JPanel();
			jContentPane.setLayout(null);
			jContentPane.setPreferredSize(new java.awt.Dimension(607, 243));
			jContentPane.add(getTxtCodigo(), null);
			jContentPane.add(jLabel1, null);
			jContentPane.add(jLabel2, null);
			jContentPane.add(jLabel3, null);
			jContentPane.add(getTxtNombre(), null);
			jContentPane.add(getTxtPrecio(), null);
			jContentPane.add(getBtnCancelar(), null);
			jContentPane.add(getBtnAceptar(), null);
			jContentPane.add(getLstProductos(), null);
			jContentPane.add(getBtnEliminar(), null);
			jContentPane.add(getCmbMarca());
			jContentPane.add(getJRBand());
			jContentPane.add(getJLabel4());
			jContentPane.add(getJTextField1());
			jContentPane.add(getJRBor());
			jContentPane.add(getJLabel5());
			jContentPane.add(getCmbMarcaABuscar());
			jContentPane.add(getBtnActualizar());
			jContentPane.add(getBtnBuscar(), null);
			jContentPane.add(getSPnPanelDeDesplazadmiento());
		}
		return jContentPane;
	}

	/**
	 * This method initializes txtCodigo	
	 * 	
	 * @return javax.swing.JTextField	
	 */
	private JTextField getTxtCodigo() {
		if (txtCodigo == null) {
			txtCodigo = new JTextField();
			txtCodigo.setText("");
			txtCodigo.setBounds(611, 62, 67, 19);
		}
		return txtCodigo;
	}

	/**
	 * This method initializes txtNombre	
	 * 	
	 * @return javax.swing.JTextField	
	 */
	private JTextField getTxtNombre() {
		if (txtNombre == null) {
			txtNombre = new JTextField();
			txtNombre.setBounds(423, 14, 254, 21);
		}
		return txtNombre;
	}

	/**
	 * This method initializes txtPrecio	
	 * 	
	 * @return javax.swing.JTextField	
	 */
	private JTextField getTxtPrecio() {
		if (txtPrecio == null) {
			txtPrecio = new JTextField();
			txtPrecio.setBounds(424, 65, 101, 22);
		}
		return txtPrecio;
	}

	/**
	 * This method initializes btnAceptar	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getBtnAceptar() {
		if (btnAceptar == null) {
			btnAceptar = new JButton();
			btnAceptar.setText("Agregar");
			btnAceptar.setBounds(379, 87, 94, 26);
			btnAceptar.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					//agregar un producto
					Producto p = new Producto(Integer.parseInt(txtCodigo.getText()),
											txtNombre.getText(),
											String.valueOf(cmbMarca.getSelectedItem()),
											Float.parseFloat(txtPrecio.getText()),
											cmbMarca.getSelectedIndex()+1);
					if (p != null)
					{
						//guarda el producto y carga la lista desde la base de datos
						try {
							ModeladorProductario.Insertador(p);
							cargadorDeProductos(false);
						}
						catch (Exception ExcepcionGeneral) {ExcepcionGeneral.getStackTrace();}
					}
				}
			});
		}
		return btnAceptar;
	}

	/**
	 * This method initializes btnCancelar	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getBtnCancelar() {
		if (btnCancelar == null) {
			btnCancelar = new JButton();
			btnCancelar.setText("Cerrar");
			btnCancelar.setLocation(new Point(776, 113));
			btnCancelar.setBounds(140, 185, 94, 26);
			btnCancelar.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					dispose();
				}
			});
		}
		return btnCancelar;
	}

	/**
	 * This method initializes lstProductos	
	 * 	
	 * @return javax.swing.JList	
	 */
	private JList getLstProductos() {
		if (lstProductos == null) {
			lstProductos = new JList();
			//getContentPane().add(barra);
			lstProductos.setBounds(17, 7, 312, 174);
			//lstProductos.setAutoscrolls(true);
			lstProductos.addListSelectionListener(new ListSelectionListener() {
				public void valueChanged(ListSelectionEvent evento) {
					if(evento.getSource() == lstProductos)
					{
						if(lstProductos.getSelectedIndex() != -1)
							lstProductosValueChanged(evento);
					}
				}
			});
		}
		return lstProductos;
	}

	/**
	 * This method initializes btnEliminar	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getBtnEliminar() {
		if (btnEliminar == null) {
			btnEliminar = new JButton();
			btnEliminar.setBounds(594, 87, 94, 26);
			btnEliminar.setText("Eliminar");
			btnEliminar.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					if (lstProductos.getSelectedIndex() >= 0)//Si hay un item seleccionado en la lista, entonces se eliminara este y se recargara la lista
					{	productoPuro=listaProductos.get(lstProductos.getSelectedIndex());
						try {
							ModeladorProductario.Eliminador(productoPuro.getCodigo());
							cargadorDeProductos(false);
							} catch (Exception ExcepcionGeneral) {ExcepcionGeneral.printStackTrace();}
					}
					else
					{
						JOptionPane op = new JOptionPane();
						JOptionPane.showMessageDialog(null, "Debe selccionar un item", "", 1);
					}
				}
			});
		}
		return btnEliminar;
	}
	
	private JComboBox getCmbMarca() {
		if(cmbMarca == null) 
		{
			ComboBoxModel cmbMarcaModel = new DefaultComboBoxModel(new String[] { "--------------" });
			cmbMarca = new JComboBox();
			cmbMarca.setModel(cmbMarcaModel);
			cmbMarca.setBounds(424, 39, 254, 21);
		}
		return cmbMarca;
	}
	
	private void lstProductosValueChanged(ListSelectionEvent evt) {
		productoPuro=listaProductos.get(lstProductos.getSelectedIndex());
		cmbMarca.removeAllItems();//Limpiamos el combobox en caso de que se seleccione otro item
		try {cargadorDeCombos(cmbMarca);}
		catch (Exception excepcionGeneral) {excepcionGeneral.printStackTrace();}
		txtCodigo.setText(String.valueOf(productoPuro.getCodigo()));//Aunque el textbox del cogido esta oculto debido a que no hace falta cambiarle eso, de todos modos se asigna el valos correspondiente para que se pueda usar de referencia a la hora de actualizar los datos
		txtNombre.setText(productoPuro.getNombre());
		txtPrecio.setText(String.valueOf(productoPuro.getPrecio()));//Convierto el valor en decimal en String para que no me de un error de casteo
		cmbMarca.setSelectedIndex(productoPuro.getIdMarca()-1);
	}
	
	private JRadioButton getJRBand() {
		if(jRBand == null) {
			jRBand = new JRadioButton();
			jRBand.setText("Y");
			jRBand.setBounds(370, 147, 34, 18);
		}
		return jRBand;
	}

	private JLabel getJLabel4() {
		if(jLabel4 == null) {
			jLabel4 = new JLabel();
			jLabel4.setText("Buscar productos que contengan");
			jLabel4.setVerticalAlignment(SwingConstants.TOP);
			jLabel4.setVerticalTextPosition(SwingConstants.TOP);
			jLabel4.setAlignmentY(0.0f);
			jLabel4.setBounds(365, 129, 194, 14);
		}
		return jLabel4;
	}
	
	private JTextField getJTextField1() {
		if(txtNombreABuscar == null) {
			txtNombreABuscar = new JTextField();
			txtNombreABuscar.setBounds(559, 126, 136, 21);
		}
		return txtNombreABuscar;
	}
	
	private JRadioButton getJRBor() {
		if(jRBor == null) {
			jRBor = new JRadioButton();
			jRBor.setText("O");
			jRBor.setBounds(369, 166, 34, 18);
		}
		return jRBor;
	}
	
	private JLabel getJLabel5() {
		if(jLabel5 == null) {
			jLabel5 = new JLabel();
			jLabel5.setText("cuya marca sea");
			jLabel5.setBounds(409, 158, 95, 14);
		}
		return jLabel5;
	}
	
	private JComboBox getCmbMarcaABuscar() {
		if(CmbMarcaABuscar == null) {
			ComboBoxModel CmbMarcaABuscarModel = 
				new DefaultComboBoxModel(
						new String[] { "-------------" });
			CmbMarcaABuscar = new JComboBox();
			CmbMarcaABuscar.setModel(CmbMarcaABuscarModel);
			CmbMarcaABuscar.setBounds(503, 151, 120, 21);
		}
		return CmbMarcaABuscar;
	}
	
	private JButton getBtnActualizar() {
		if(btnActualizar == null) {
			btnActualizar = new JButton();
			btnActualizar.setText("Actualizar");
			btnActualizar.setBounds(480, 86, 107, 28);
			btnActualizar.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					//agregar un producto
					Producto p = new Producto(Integer.parseInt(txtCodigo.getText()),
											txtNombre.getText(),
											String.valueOf(cmbMarca.getSelectedItem()),
											Float.parseFloat(txtPrecio.getText()),
											cmbMarca.getSelectedIndex()+1);
					if (p != null)
					{
						//actualiza el producto y carga la lista desde la base de datos
						try {
							ModeladorProductario.Modificador(p);
							cargadorDeProductos(false);
						} catch (Exception ExcepcionGeneral) {ExcepcionGeneral.getCause();}
					}
				}	
			});
		}
		return btnActualizar;
	}
	
	public void cargadorDeCombos(JComboBox Lista) throws Exception
	{
		if(productoPuro != null)//Verifico que la instancia de la clase producto no sea nula ya que de ser asi, se podria generar un NullPointerException cuando, por ejemplo, cuando se abre la ventana o cuando se quiere usar el buscador
			{productoPuro=ModeladorProductario.SeleccionadorUnitario(productoPuro.getCodigo());}
		ResultSet marcas=ModeladorProductario.llenadorDeComboBoxDeMarca();
		while(marcas.next() == true)
		{
			Lista.addItem(marcas.getString("nombre"));
		}
		ModeladorProductario.enlace.desconectar();
	}
	
	public void cargadorDeProductos(boolean clicBotonBuscar) throws Exception//Esto se usara cuando para cargar la lista cada vez que la ventana se abre, cuando se crea, modifica o elimina un registro y cuando se usa el buscador
	{
		if(clicBotonBuscar == false)
		{
		listaProductos=ModeladorProductario.Buscador("", "", "and");
		jRBand.setSelected(true);
		}
		lstProductos.setListData(listaProductos);
		cmbMarca.removeAllItems();
		if(CmbMarcaABuscar.getItemCount() == 1)//Antes de cargar este ciomponente verifico que tenga solo un item (la linea formada con guiones) dentro para evitar que se carguen una y otra vez los mismos items
			cargadorDeCombos(CmbMarcaABuscar);//Esto carga el combobox que se usara en el momento de las busquedas
		txtCodigo.setText("");//Aunque el textbox del cogido esta oculto debido a que no hace falta cambiarle eso, de todos modos se asigna el valos correspondiente para que se pueda usar de referencia a la hora de actualizar los datos
		txtNombre.setText("");
		txtPrecio.setText("");
		cmbMarca.setSelectedIndex(-1);
		productoPuro=null;
	}

	/**
	 * This method initializes btnBuscar	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getBtnBuscar() {
		if (btnBuscar == null) {
			btnBuscar = new JButton();
			btnBuscar.setBounds(new Rectangle(475, 185, 112, 26));
			btnBuscar.setText("Buscar");
			btnBuscar.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					String cadenaDisyuntiva="";
					String marcaParaBuscar=String.valueOf(CmbMarcaABuscar.getSelectedIndex());
					if (jRBand.isSelected() == true)
					{cadenaDisyuntiva="and";}
					else
					{cadenaDisyuntiva="or";}
					if(CmbMarcaABuscar.getSelectedIndex() < 1)
						marcaParaBuscar="";
					try{
						listaProductos=ModeladorProductario.Buscador(marcaParaBuscar, txtNombreABuscar.getText(), cadenaDisyuntiva);
						cargadorDeProductos(true);
					}
					catch(Exception ExcepcionGeneral){ExcepcionGeneral.getStackTrace();}
				}});
		}
		return btnBuscar;
	}
	
	private JScrollPane getSPnPanelDeDesplazadmiento() {
		if(SPnPanelDeDesplazadmiento == null) {
			SPnPanelDeDesplazadmiento = new JScrollPane(lstProductos);
			SPnPanelDeDesplazadmiento.setBounds(12, 7, 341, 177);
		}
		return SPnPanelDeDesplazadmiento;
	}

}  //  @jve:decl-index=0:visual-constraint="13,51"

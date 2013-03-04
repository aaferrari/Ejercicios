import javax.swing.SwingUtilities;
import java.awt.BorderLayout;

import javax.swing.JPanel;
import javax.swing.JFrame;
import javax.swing.JMenuBar;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import javax.swing.JTextField;

public class Principal extends JFrame {

	private static final long serialVersionUID = 1L;

	private JPanel jContentPane = null;

	private JMenuBar miMenuBar = null;

	private JMenu mnuPrincipal = null;

	private JMenuItem mnuItemABM = null;

	private JMenuItem mnuItemCargar = null;

	private JMenuItem mnuItemListar = null;

	/**
	 * This is the default constructor
	 */
	public Principal() {
		super();
		initialize();
	}

	/**
	 * This method initializes this
	 * 
	 * @return void
	 */
	private void initialize() {
		this.setSize(300, 200);
		this.setJMenuBar(getMiMenuBar());
		this.setContentPane(getJContentPane());
		this.setTitle("JFrame");
	}

	/**
	 * This method initializes miMenuBar	
	 * 	
	 * @return javax.swing.JMenuBar	
	 */
	private JMenuBar getMiMenuBar() {
		if (miMenuBar == null) {
			miMenuBar = new JMenuBar();
			miMenuBar.add(getMnuPrincipal());
		}
		return miMenuBar;
	}

	/**
	 * This method initializes mnuPrincipal	
	 * 	
	 * @return javax.swing.JMenu	
	 */
	private JMenu getMnuPrincipal() {
		if (mnuPrincipal == null) {
			mnuPrincipal = new JMenu();
			mnuPrincipal.setText("Productos");
			mnuPrincipal.add(getMnuItemABM());
		}
		return mnuPrincipal;
	}

	private JMenuItem getMnuItemABM() {
		if (mnuItemABM == null) {
			mnuItemABM = new JMenuItem();
			mnuItemABM.setText("ABM");
			mnuItemABM.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					ABMProducto cp;
					try {
						cp = new ABMProducto();
						cp.setVisible(true);
					} catch (Exception e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
					
				}
			});
		}
		return mnuItemABM;
	}


	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				Principal thisClass = new Principal();
				thisClass.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
				thisClass.setVisible(true);
			}
		});
	}

	
	/**
	 * This method initializes jContentPane
	 * 
	 * @return javax.swing.JPanel
	 */
	private JPanel getJContentPane() {
		if (jContentPane == null) {
			jContentPane = new JPanel();
			jContentPane.setLayout(new BorderLayout());
		}
		return jContentPane;
	}

}

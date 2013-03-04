
public class Prueba {
	
	public Prueba(){
		try{
		String loquesea=null;
		System.out.println(loquesea.toLowerCase());
		}
		catch(NullPointerException A){
			System.out.println("Puntero nulo");
			NullPointerException.this.printStackTrace();
		}
	}
}
 
import java.util.Scanner;


public class DecimalToHex {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int a = sc.nextInt();
		
		System.out.println(Integer.toHexString(a).toUpperCase());
		
	}
	
}
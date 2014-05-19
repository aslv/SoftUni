import java.util.Scanner;


public class CountBitsOne {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		//System.out.println(Integer.toBinaryString(n));
		
		int count = 0;
		String binaryRepresentation = Integer.toBinaryString(n);
		for (int i = 0; i < binaryRepresentation.length(); i++) {
			if (binaryRepresentation.charAt(i) == '1') {
				count++;
			}
		}
		System.out.println(count);

	}

}

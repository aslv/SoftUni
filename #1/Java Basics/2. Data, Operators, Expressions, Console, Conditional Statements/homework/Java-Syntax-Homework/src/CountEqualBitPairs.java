import java.util.Scanner;


public class CountEqualBitPairs {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		//System.out.println(Integer.toBinaryString(n));
		
		int count = 0;
		String binaryRepresentation = Integer.toBinaryString(n);
		String sub;
		for (int i = 0, lenMinus1 = binaryRepresentation.length() - 1; i < lenMinus1; i++) {
			sub = binaryRepresentation.substring(i, i + 2);
			if (sub.equals("00") || sub.equals("11")) {
				count++;
			}
		}
		System.out.println(count);

	}

}

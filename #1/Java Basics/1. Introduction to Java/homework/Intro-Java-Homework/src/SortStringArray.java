import java.util.Arrays;
import java.util.Scanner;


public class SortStringArray {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		String[] elements = new String[n];
		for (int i = 0; i < n; i++) {
			elements[i] = in.next();
		}
		Arrays.sort(elements);
		System.out.println(Arrays.toString(elements));
		in.close();
	}
}

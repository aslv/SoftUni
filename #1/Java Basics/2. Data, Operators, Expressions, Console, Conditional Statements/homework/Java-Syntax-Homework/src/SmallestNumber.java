import java.util.Scanner;


public class SmallestNumber {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		double a = sc.nextDouble();
		double b = sc.nextDouble();
		double c = sc.nextDouble();
		
		double smallest = a;
		if (smallest > b) {
			smallest = b;
		}
		if (smallest > c) {
			smallest = c;
		}
		System.out.println("The smallest number is " + smallest);

	}

}

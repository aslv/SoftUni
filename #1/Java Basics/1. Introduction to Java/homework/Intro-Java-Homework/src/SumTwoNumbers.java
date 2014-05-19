import java.util.InputMismatchException;
import java.util.NoSuchElementException;
import java.util.Scanner;


public class SumTwoNumbers {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int a, b, sum;
		try {
			a = in.nextInt();
			b = in.nextInt();
			sum = a + b;
			System.out.printf("The sum of %d and %d is %d.\n", a, b, sum);
		} catch (InputMismatchException e) {
			System.err.println("The entered number(s) is(are) not integer(s)!");
		} catch (NoSuchElementException e) {
			System.err.println("Please provide TWO (2) integers!");
		} catch (IllegalStateException e) {
			System.err.println("The reading failed due to closed scanner!");
		} catch (Exception e) {
			System.err.println("An error occurred (unknown type)!");
		}
		in.close();
	}

}

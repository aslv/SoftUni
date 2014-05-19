import java.util.Locale;
import java.util.Scanner;


public class PointInsideFigure {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		
		Scanner sc = new Scanner(System.in);
		double x = sc.nextDouble();
		double y = sc.nextDouble();
		
		boolean isInside = isPointInsideRectangle(x, y, 13.5, 8.5, 12.5, 17.5) || isPointInsideRectangle(x, y, 8.5, 6, 12.5, 22.5) || isPointInsideRectangle(x, y, 13.5, 8.5, 20, 22.5);
		System.out.println("The point is " + (isInside ? "in" : "out") + "side the figure.");
	}

	private static boolean isPointInsideRectangle(double x, double y, double up, double down, double left, double right) {
		if(y <= up && y >= down && x >= left && x <= right) {
			return true;
		}
		return false;
	}

}

import java.util.Locale;
import java.util.Scanner;


public class PointInsideHouse {

	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		
		Scanner sc = new Scanner(System.in);
		double x = sc.nextDouble();
		double y = sc.nextDouble();
		
		boolean isInside = isPointInsideRectangle(x, y, 13.5, 8.5, 12.5, 17.5) || isPointInsideTriangle(x, y, 8.5, 12.5, 22.5, 17.5, 3.5) || isPointInsideRectangle(x, y, 13.5, 8.5, 20, 22.5);
		System.out.println("The point is " + (isInside ? "in" : "out") + "side the house.");
		//System.out.println(isPointInsideRectangle(x, y, 13.5, 8.5, 12.5, 17.5));
		//System.out.println(isPointInsideTriangle(x, y, 8.5, 12.5, 22.5, 17.5, 3.5));
		//System.out.println(isPointInsideRectangle(x, y, 13.5, 8.5, 20, 22.5));
	}

	private static boolean isPointInsideTriangle(double x, double y, double bottom, double left, double right, double topX, double topY) {
		//position = sign( (Bx-Ax)*(Y-Ay) - (By-Ay)*(X-Ax) )
		double mult1, mult2;
		mult1 = topX - left;
		mult2 = topY - bottom;
		if((mult1 * (y - bottom) - mult2 * (x - left)) < 0) { // /
			return false;
		}
		mult1 = right - topX;
		mult2 = bottom - topY;
		if((mult1 * (y - topY) - mult2 * (x - topX)) < 0) { // \
			return false;
		}
		mult1 = left - right; // always mult2 == 0
		if((mult1 * (y - bottom)) < 0) { // _
			return false;
		}
		return true;
	}
	
	private static boolean isPointInsideRectangle(double x, double y, double up, double down, double left, double right) {
		if(y <= up && y >= down && x >= left && x <= right) {
			return true;
		}
		return false;
	}

}

import java.util.Scanner;


public class TriangleArea {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int ax = sc.nextInt();
		int ay = sc.nextInt();
		int bx = sc.nextInt();
		int by = sc.nextInt();
		int cx = sc.nextInt();
		int cy = sc.nextInt();
		
		double area = Math.abs((ax * (by - cy) + bx * (cy - ay) + cx * (ay - by)) / 2);
		int surface = (int)(area + 0.5); // rounding
		System.out.println("The area of the triangle is " + surface);
	}

}

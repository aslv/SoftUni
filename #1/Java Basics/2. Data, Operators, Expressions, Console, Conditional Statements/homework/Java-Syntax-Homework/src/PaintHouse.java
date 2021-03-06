import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Locale;
import java.util.Scanner;

public class PaintHouse {

	private static class Point {
		public double x;
		public double y;
		
		public Point(double x, double y) {
			this.x = x;
			this.y = y;
		}
	}
	
	private static String FILENAME = "house.html";
	
	public static void main(String[] args) throws FileNotFoundException {
		Locale.setDefault(Locale.ROOT);
		System.out.println("Please enter the number of points and then the points as ordered pairs by their coordinates:\n// Hint: just copy the input data from the file \'input.txt\' or from the homework");
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		Point[] points = new Point[n];
		double ax, ay;
		for (int i = 0; i < n; i++) {
			ax = sc.nextDouble();
			ay = sc.nextDouble();
			points[i] = new Point(ax, ay);
		}
		
		try(PrintWriter writer = new PrintWriter(FILENAME)) {
			String content = "<!DOCTYPE html><html><head><title>House</title></head><body><svg height=\"1024\" width=\"1024\">";
			
			// the coordinate plane
			String style = "style=\"stroke:aqua;stroke-width:1;stroke-opacity:0.8\"";
			for(int x = 0; x <= 1000; x += 100) {
				for (int y = 0; y < 1000; y += 20) {
					content += "<line x1=\"" + x + "\" y1=\"" + y + "\" x2=\"" + x + "\" y2=\"" + (y + 10) + "\" " + style + " />";
				}
				if(x > 0) {
					content += "<text x=\"" + (x - 10) + "\" y=\"" + 15 +"\" fill=\"black\">" + String.format("%.1f", x / 40.) + "</text>";
				}
			}
			content += "<text x=\"" + 5 + "\" y=\"" + 15 +"\" fill=\"black\">" + String.format("%.1f", 0.) + "</text>";
			for (int y = 0; y <= 1000; y += 100) {
				for (int x = 0; x < 1000; x += 20) {
					content += "<line x1=\"" + x + "\" y1=\"" + y + "\" x2=\"" + (x + 10) + "\" y2=\"" + y + "\" " + style + " />";
				}
				if (y > 0) {
					content += "<text x=\"" + 5 + "\" y=\"" + (y + 5) +"\" fill=\"black\">" + (y / 40.)/*String.format("%.1f", y / 40.)*/ + "</text>";
				}
			}

			// the house
			style = "style=\"fill:gray;stroke:darkblue;stroke-width:3;fill-opacity:0.5;stroke-opacity:0.9\"";
			//content += "<rect x=\"125\" y=\"85\" width=\"50\" height=\"50\" " + style + "/>";
			//content += "<rect x=\"200\" y=\"85\" width=\"25\" height=\"50\" " + style + "/>";
			//content += "<polygon points=\"125,85 225,85 175,35\" " + style + "/>";
			content += "<rect x=\"500\" y=\"340\" width=\"200\" height=\"200\" " + style + "/>";
			content += "<rect x=\"800\" y=\"340\" width=\"100\" height=\"200\" " + style + "/>";
			content += "<polygon points=\"500,340 900,340 700,140\" " + style + "/>";
			
			// the points
			for (int i = 0; i < n; i++) {
				content += "<circle cx=\"" + (points[i].x * 40) + "\" cy=\"" + (points[i].y * 40) + "\" r=\"5\" ";
				if(isInsideHouse(points[i].x, points[i].y)) {
					style = "style=\"fill:black;stroke:black;stroke-width:2\"";
				}
				else {
					style = "style=\"fill:gray;stroke:black;stroke-width:2;stroke-opacity:0.5\"";
				}
				content += style + " />";
			}
			
			content += "</svg></body></html>";
			writer.println(content);
		}
		
		System.out.println("Building SVG successfully!");

	}
	
	private static boolean isInsideHouse(double x, double y) {
		return isPointInsideRectangle(x, y, 13.5, 8.5, 12.5, 17.5) || isPointInsideTriangle(x, y, 8.5, 12.5, 22.5, 17.5, 3.5) || isPointInsideRectangle(x, y, 13.5, 8.5, 20, 22.5);
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

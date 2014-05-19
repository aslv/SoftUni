import java.util.Locale;
import java.util.Scanner;

import org.apache.commons.lang.StringUtils;

public class FormattingNumbers {

	public static void main(String[] args) {
		System.out.println("Please enter three (3) numbers:\nAn integer;\nA floating-point;\nAnd also a floating point number.");
		Locale.setDefault(Locale.ROOT);
		Scanner sc = new Scanner(System.in);
		int a = sc.nextInt();
		double b = sc.nextDouble();
		double c = sc.nextDouble();
		
		System.out.printf("|%-10s|%10s|%10.2f|%-10.3f|\n", Integer.toHexString(a).toUpperCase(), StringUtils.leftPad(Integer.toBinaryString(a), 10, '0'), b, c);

	}

}

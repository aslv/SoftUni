import java.text.SimpleDateFormat;
import java.util.Calendar;


public class CurrentDateTime {

	public static void main(String[] args) {
		System.out.println(new SimpleDateFormat("dd.MM.yyyy HH:mm:ss").format(Calendar.getInstance().getTime()));

	}

}

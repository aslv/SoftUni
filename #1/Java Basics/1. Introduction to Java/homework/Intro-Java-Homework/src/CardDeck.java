import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;

import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Chunk;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Element;
import com.itextpdf.text.Font;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.Phrase;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;


public class CardDeck {

	private static String PATH = "PDF" + File.separator;
	private static String FILENAME = "GeneratedPDF.pdf";
	private static String NEWLINE = System.lineSeparator();
	
	public static void main(String[] args) throws FileNotFoundException, DocumentException {
		String[] numbers = new String[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
		char[] suits = new char[] { '\u2663', '\u2666', '\u2665', '\u2660' };
		/*
		for (int i = 0; i < numbers.length; i++) {
			for (int j = 0; j < suits.length; j++) {
				System.out.printf("%2s%c ", numbers[i], suits[j], " ");
			}
			System.out.println();
		}
		*/
		try {
			Document document = new Document();
			PdfWriter.getInstance(document, new FileOutputStream(PATH + FILENAME));
			document.open();
			
			Paragraph intro = new Paragraph("A Print of a Standard Deck", new Font(Font.FontFamily.TIMES_ROMAN, 20, Font.BOLD));
			document.add(intro);
			
			BaseFont bf = BaseFont.createFont(PATH + "times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
			
			Paragraph content = new Paragraph("", new Font(bf, 12, Font.NORMAL, BaseColor.RED));
			content.setSpacingBefore(60);
			PdfPTable border;
			PdfPCell cell;
			Chunk chunk;
			PdfPTable row;
			for (int i = 0; i < numbers.length; i++) {
				row = new PdfPTable(4);
				row.getDefaultCell().setPaddingLeft(30);
				row.getDefaultCell().setPaddingRight(30);
				row.getDefaultCell().setBorder(0);
				for (int j = 0; j < suits.length; j++) {
					if(j == 1 || j == 2) {
						chunk = new Chunk(String.format("%2s %c", numbers[i], suits[j]), new Font(bf, 12, Font.NORMAL, BaseColor.RED));
					}
					else {
						chunk = new Chunk(String.format("%2s %c", numbers[i], suits[j]), new Font(bf, 12, Font.NORMAL, BaseColor.BLACK));
					}
					//content.add(chunk);
					border = new PdfPTable(1);
					//border.setSpacingBefore(6);
					//border.setSpacingAfter(6);
					//border.setWidthPercentage(12);
					cell = new PdfPCell(new Phrase(chunk));
					//cell.setPaddingLeft(22);
					//cell.setPaddingRight(22);
					cell.setPaddingTop(23);
					cell.setPaddingBottom(23);
					cell.setHorizontalAlignment(Element.ALIGN_CENTER);
					cell.setVerticalAlignment(Element.ALIGN_MIDDLE);
					border.addCell(cell);
					row.addCell(border);
				}
				content.add(row);
				content.add(NEWLINE);
			}
			document.add(content);
			
			document.close();
		} catch (Exception e) {
			System.err.println("An error occurred!");
			e.printStackTrace(System.err);
		}
		
		
	}

}

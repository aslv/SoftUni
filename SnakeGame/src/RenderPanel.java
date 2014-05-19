import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;

import javax.swing.JPanel;


@SuppressWarnings("serial")
public class RenderPanel extends JPanel {
	 
   
    @Override
    protected void paintComponent(Graphics g) {
            super.paintComponent(g);
            g.setColor(Color.BLACK);
            g.fillRect(0, 0, 600, 500);
            Snake snake = Snake.snake;
            g.setColor(Color.GREEN);
            for (Point point : snake.snakeParts) {
                    g.fillRect(point.x * Snake.SCALE, point.y * Snake.SCALE,
                                    Snake.SCALE, Snake.SCALE);
            }
            g.fillRect(snake.head.x * Snake.SCALE, snake.head.y * Snake.SCALE,
                            Snake.SCALE, Snake.SCALE);
            g.setColor(Color.RED);
            g.fillRect(snake.apple.x * Snake.SCALE, snake.apple.y * Snake.SCALE,
                            Snake.SCALE, Snake.SCALE);
            String string = "Score: " + snake.score + ", Length: "
                            + snake.tailLength + ", Time: " + snake.time / 20;
            g.setColor(Color.white);
            g.drawString(string, (int) (getWidth() / 2 - string.length() * 2.5f),
                            10);
            string = "Game Over!";
            if (snake.over)
                    g.drawString(string,
                                    (int) (getWidth() / 2 - string.length() * 2.5f),
                                    (int) snake.dim.getHeight() / 4);
            string = "Paused!";
            if (snake.paused && !snake.over)
                    g.drawString(string,
                                    (int) (getWidth() / 2 - string.length() * 2.5f),
                                    (int) snake.dim.getHeight() / 4);
    }
}
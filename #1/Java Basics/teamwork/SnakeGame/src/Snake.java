import java.awt.Dimension;
import java.awt.Point;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.ArrayList;
import java.util.Random;

import javax.swing.JFrame;
import javax.swing.Timer;

public class Snake implements ActionListener, KeyListener {

	public static Snake snake;

	public JFrame jframe;

	public RenderPanel renderPanel;

	public static final int UP = 0, DOWN = 1, LEFT = 2, RIGHT = 3, SCALE = 10,
			X = 59, Y = 36;

	public int ticks = 0, direction = DOWN, score, tailLength, time, delay,
			initialDelay = 100;

	public Timer timer = new Timer(initialDelay, this);

	public ArrayList<Point> snakeParts = new ArrayList<Point>(),
			stones = new ArrayList<Point>();

	public Point head, apple;

	public Random random;

	public boolean over = false, paused;

	public Dimension dim;

	public Snake() {
		dim = Toolkit.getDefaultToolkit().getScreenSize();
		jframe = new JFrame("Snake");
		jframe.setVisible(true);
		jframe.setSize(600, 500);
		jframe.setResizable(false);
		jframe.setLocation(dim.width / 2 - jframe.getWidth() / 2, dim.height
				/ 2 - jframe.getHeight() / 2);
		jframe.add(renderPanel = new RenderPanel());
		jframe.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		jframe.addKeyListener(this);
		startGame();
	}

	public void startGame() {
		over = false;
		paused = false;
		time = 0;
		score = 0;
		tailLength = 1;
		timer.setDelay(initialDelay);
		delay = initialDelay;
		ticks = 0;
		direction = DOWN;
		head = new Point(0, -1);
		random = new Random();
		snakeParts.clear();
		stones.clear();
		apple = new Point(random.nextInt(X), random.nextInt(Y));
		// System.out.println(apple.x);
		// System.out.println(apple.y);
		timer.start();
	}

	@Override
	public void actionPerformed(ActionEvent arg0) {
		renderPanel.repaint();
		ticks++;
		if (ticks % 2 == 0 && head != null && !over && !paused) {
			time++;
			snakeParts.add(new Point(head.x, head.y));
			if (direction == UP)
				if (head.y - 1 >= 0 && noTailAt(head.x, head.y - 1))
					head = new Point(head.x, head.y - 1);
				else
					over = true;
			if (direction == DOWN)
				if (head.y + 1 < 67 && noTailAt(head.x, head.y + 1))
					head = new Point(head.x, head.y + 1);
				else
					over = true;
			if (direction == LEFT)
				if (head.x - 1 >= 0 && noTailAt(head.x - 1, head.y))
					head = new Point(head.x - 1, head.y);
				else
					over = true;
			if (direction == RIGHT)
				if (head.x + 1 < 80 && noTailAt(head.x + 1, head.y))
					head = new Point(head.x + 1, head.y);
				else
					over = true;
			if (snakeParts.size() > tailLength)
				snakeParts.remove(0);
			if (apple != null) {
				if (head.equals(apple)) {
					if (delay > 50) {
						delay -= 10;
					}
					timer.setDelay(delay);
					score += tailLength + (initialDelay - delay);
					tailLength++;
					apple.setLocation(random.nextInt(X), random.nextInt(Y));
					stones.add(generateStone());
				}
			}
			for (Point stone : stones) {
				if (head.equals(stone)) {
					over = true;
					break;
				}
			}
		}
	}

	public boolean noTailAt(int x, int y) {
		for (Point point : snakeParts) {
			if (point.equals(new Point(x, y))) {
				return false;
			}
		}
		return true;
	}

	public Point generateStone() {
		int x, y;
		boolean overlapping;
		Point stone = new Point();
		do {
			overlapping = false;
			x = random.nextInt(X);
			y = random.nextInt(Y);
			stone.setLocation(x, y);
			// for snake parts
			for (Point point : snakeParts) {
				if (point.equals(stone)) {
					overlapping = true;
					break;
				}
			}
			// for snake head
			if (head.equals(stone)) {
				overlapping = true;
			}
			// for the apple
			if (apple.equals(stone)) {
				overlapping = true;
			}
			// for the other stones
			for (Point point : stones) {
				if (point.equals(stone)) {
					overlapping = true;
					break;
				}
			}
		} while (overlapping);
		return stone;
	}

	public static void main(String[] args) {
		snake = new Snake();
	}

	@Override
	public void keyPressed(KeyEvent e) {
		int i = e.getKeyCode();
		if ((i == KeyEvent.VK_A || i == KeyEvent.VK_LEFT) && direction != RIGHT)
			direction = LEFT;
		if ((i == KeyEvent.VK_D || i == KeyEvent.VK_RIGHT) && direction != LEFT)
			direction = RIGHT;
		if ((i == KeyEvent.VK_W || i == KeyEvent.VK_UP) && direction != DOWN)
			direction = UP;
		if ((i == KeyEvent.VK_S || i == KeyEvent.VK_DOWN) && direction != UP)
			direction = DOWN;
		if (i == KeyEvent.VK_SPACE)
			if (over)
				startGame();
			else
				paused = !paused;
	}

	@Override
	public void keyReleased(KeyEvent e) {
	}

	@Override
	public void keyTyped(KeyEvent e) {
	}

}
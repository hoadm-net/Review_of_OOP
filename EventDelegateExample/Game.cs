namespace EventDelegateExample;

public class Game
{
    private int Width { get; }
    private int Height { get; }
    private Snake Snake { get; set; }
    private Food Food { get; set; }
    private bool GameOver { get; set; }
    private int Score { get; set; }

    public Game(int width, int height)
    {
        Width = width;
        Height = height;
        Snake = new Snake(width / 2, height / 2);
        Food = new Food(width, height);
        GameOver = false;
        Score = 0;
        
        Snake.OnEatFood += HandleEatFood;
        Snake.OnEatFood += HandleEatFoodSound;
    }

    private void HandleEatFood(object? sender, EventArgs e)
    {
        Score++;
        Snake.Grow();
        Food.Generate(Snake.Body);
    }

    private void HandleEatFoodSound(object? sender, EventArgs e)
    {
        Console.Beep();
    }

    public void Start()
    {
        Console.CursorVisible = false;
        Food.Generate(Snake.Body);
        while (!GameOver)
        {
            Draw();
            Input();
            Logic();
            Thread.Sleep(300);
        }
        Console.Clear();
        Console.WriteLine($"Game Over! Final Score: {Score}");
    }

    private void Draw()
    {
        Console.Clear();
        Board.DrawBorder(Width, Height);
        Snake.Draw();
        Food.Draw();
        Console.SetCursorPosition(0, Height);
        Console.WriteLine($"Score: {Score}");
    }

    private void Input()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            Snake.ChangeDirection(key);
        }
    }

    private void Logic()
    {
        Snake.Move();
        if (Snake.HasCollided(Width, Height))
        {
            GameOver = true;
            return;
        }

        if (Snake.Head.Equals(Food.Position))
        {
            Snake.TriggerEatFood();
        }
    }
}
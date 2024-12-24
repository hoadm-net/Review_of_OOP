namespace EventDelegateExample;

public class Board
{
    public static void DrawBorder(int width, int height)
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("#");
                }
            }
        }
    }
}
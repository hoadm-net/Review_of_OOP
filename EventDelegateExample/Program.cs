﻿namespace EventDelegateExample;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game(40, 20);
        game.Start();
    }
}
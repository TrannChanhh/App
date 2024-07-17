using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        static int width = 40;
        static int height = 20;
        static int score = 0;
        static bool gameover = false;

        static List<(int, int)> snake = new List<(int, int)>();
        static (int, int) food;
        static (int, int) direction = (1, 0);

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            InitializeGame();
            while (!gameover)
            {
                Update();
                Draw();
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    ChangeDirection(key);
                }
            }
            Console.Clear();
            Console.WriteLine("Game Over! Your score: " + score);
        }

        static void InitializeGame()
        {
            snake.Add((width / 2, height / 2));
            GenerateFood();
        }

        static void Update()
        {
            var head = snake[0];
            var newHead = (head.Item1 + direction.Item1, head.Item2 + direction.Item2);

            if (newHead.Item1 < 0 || newHead.Item2 < 0 || newHead.Item1 >= width || newHead.Item2 >= height || snake.Contains(newHead))
            {
                gameover = true;
                return;
            }

            snake.Insert(0, newHead);

            if (newHead == food)
            {
                score++;
                GenerateFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }

        static void Draw()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == food.Item1 && y == food.Item2)
                    {
                        Console.Write("O");
                    }
                    else if (snake.Contains((x, y)))
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Score: " + score);
        }

        static void GenerateFood()
        {
            var random = new Random();
            do
            {
                food = (random.Next(width), random.Next(height));
            } while (snake.Contains(food));
        }

        static void ChangeDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W when direction != (0, 1):
                    direction = (0, -1);
                    break;
                case ConsoleKey.S when direction != (0, -1):
                    direction = (0, 1);
                    break;
                case ConsoleKey.A when direction != (1, 0):
                    direction = (-1, 0);
                    break;
                case ConsoleKey.D when direction != (-1, 0):
                    direction = (1, 0);
                    break;
            }
        }
    }
} 
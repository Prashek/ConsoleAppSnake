﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    class Program
    {
        private static int Score;  // добавил очки (загуглил)
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // убираю мерцающий курсор 
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            Console.SetWindowSize(80, 25);  // пришлось добавить, потому что не запускалось с SetBufferSize
            Console.SetBufferSize(80, 25);  // проверка
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');


            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();



            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    Score += 100;   // добавил очки (загуглил)
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                snake.HandleKey();
                System.Threading.Thread.Sleep(100);
            }
            Console.SetCursorPosition(80 / 3, 25 / 2);   // загуглил
            Console.ForegroundColor = ConsoleColor.Yellow; // загуглил
            Console.BackgroundColor = ConsoleColor.Red;   // загуглил
            Console.Write($"Игра окончена!  "); // добавил очки (загуглил)
            Console.WriteLine($"Очки: { Score}");

            Console.ReadLine();
        }
    }
}
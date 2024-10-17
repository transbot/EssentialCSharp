namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_06;

#region INCLUDE
using System;
using System.Collections.Generic;

public class Program
{
    #region EXCLUDE
    public static void Main()
    {
        Sketch();
    }
    #endregion EXCLUDE

    public static void Sketch()
    {
        #region HIGHLIGHT
        Stack<Cell> path = new();
        #endregion HIGHLIGHT
        Cell currentPosition;
        ConsoleKeyInfo key;
        #region EXCLUDE
        Console.WriteLine("按箭头键画图，按X退出。"); 
        for(int i = 2; i < Console.WindowHeight; i++)
        {
            Console.WriteLine();
        }

        currentPosition = new Cell(Console.WindowWidth / 2, Console.WindowHeight / 2);
        path.Push(currentPosition);
        FillCell(currentPosition);
        #endregion EXCLUDE

        do
        {
            // 根据用户所按箭头键的方向进行绘制
            key = Move();

            switch(key.Key)
            {
                case ConsoleKey.Z:
                    // 撤消上一次移动
                    if(path.Count >= 1)
                    {
                        #region HIGHLIGHT
                        // 不需要转型
                        currentPosition = path.Pop();
                        #endregion HIGHLIGHT
                        Console.SetCursorPosition(
                            currentPosition.X, currentPosition.Y);
                        FillCell(currentPosition, ConsoleColor.Black);
                        Undo();
                    }
                    break;
                case ConsoleKey.DownArrow:
                    #region EXCLUDE
                    if (Console.CursorTop < Console.WindowHeight - 2)
                    {
                        currentPosition = new Cell(
                            Console.CursorLeft, Console.CursorTop + 1);
                    }
                    // 调用Push()时只允许传递Cell类型
                    path.Push(currentPosition);
                    FillCell(currentPosition);
                    break;
                    #endregion EXCLUDE
                case ConsoleKey.UpArrow:
                    #region EXCLUDE
                    if (Console.CursorTop > 1)
                    {
                        currentPosition = new Cell(
                            Console.CursorLeft, Console.CursorTop - 1);
                    }
                    // 调用Push()时只允许传递Cell类型
                    path.Push(currentPosition);
                    FillCell(currentPosition);
                    break;
                    #endregion EXCLUDE
                case ConsoleKey.LeftArrow:
                    #region EXCLUDE
                    if (Console.CursorLeft > 1)
                    {
                        currentPosition = new Cell(
                            Console.CursorLeft - 1, Console.CursorTop);
                    }
                    // 调用Push()时只允许传递Cell类型
                    path.Push(currentPosition);
                    FillCell(currentPosition);
                    break;
                    #endregion EXCLUDE
                case ConsoleKey.RightArrow:
                    // SaveState()
                    if(Console.CursorLeft < Console.WindowWidth - 2)
                    {
                        currentPosition = new Cell(
                            Console.CursorLeft + 1, Console.CursorTop);
                    }
                    #region HIGHLIGHT
                    // 调用Push()时只允许传递Cell类型
                    path.Push(currentPosition);
                    #endregion HIGHLIGHT
                    FillCell(currentPosition);
                    break;

                default:
                    Console.Beep();
                    break;
            }

        }
        while(key.Key != ConsoleKey.X);  // 按X退出
    }
    #region EXCLUDE
    private static ConsoleKeyInfo Move()
    {
        return Console.ReadKey(true);
    }

    private static void Undo()
    {
        // stub
    }

    private static void FillCell(Cell cell)
    {
        FillCell(cell, ConsoleColor.White);
    }

    private static void FillCell(Cell cell, ConsoleColor color)
    {
        Console.SetCursorPosition(cell.X, cell.Y);
        Console.BackgroundColor = color;
        Console.Write(' ');
        Console.SetCursorPosition(cell.X, cell.Y);
        Console.BackgroundColor = ConsoleColor.Black;
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
public struct Cell
{
    public readonly int X;
    public readonly int Y;

    public Cell(int x, int y)
    {
        X = x;
        Y = y;
    }
}

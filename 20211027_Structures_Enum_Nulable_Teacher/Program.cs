using System;
using System.Windows.Forms;

namespace Structs
{
    enum Color
    {
        Red=65,
        Green,
        Blue=34
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*var rand = new Random();
            Point a = new Point(102,293);
            Point b = new Point(102,293);
            Console.WriteLine(a);
            Console.WriteLine(a==b);
            Point[] arr = new Point[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Point(rand.Next(20), rand.Next(20));
            }

            foreach (var point in arr)
            {
                Console.WriteLine(point);
            }
            Array.Sort(arr);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var point in arr)
            {
                Console.WriteLine(point);
            }*/
            /*Console.ForegroundColor = ConsoleColor.Red;
            Color a = (Color)34;
            Console.WriteLine((int)a);
            switch (a)
            {
                case Color.Red:
                    Console.WriteLine("Red");
                    break;
                case Color.Green:
                    Console.WriteLine("Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("Blue");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }*/
            int a = 5;
            /*foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = color;
                Console.BackgroundColor = (15-color);
                Console.WriteLine($"Key: {(int)color,-4} -> Color: {color, -15}");
            }*/
            /*foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine($"Key: {(int)color,-4} -> Color: {color, -15}");
            }*/
            /*foreach (var key in Enum.GetValues(typeof(Keys)))
            {
                Console.WriteLine($"Key: {key,-10} -> Code: {(int)key}");
            }*/
            var rand = new Random();
            string str = rand.Next(2) == 0 ? "Hello" : null;
            int? len = str?.Length;
            int size = len ?? 0;
            /*if (len.HasValue)
                size = len.Value;
            else
                size = 0;*/
            Console.WriteLine(size);
        }
    }
}
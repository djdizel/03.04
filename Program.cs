using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            bool flag = true;

            do
            {
                Console.WriteLine("\nВыберите тип фигуры:");
                Console.WriteLine("r - Прямоугольник");
                Console.WriteLine("s - Квадрат");
                Console.WriteLine("t - Треугольник");
                Console.WriteLine("c - Круг");
                Console.WriteLine("q - Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "r":
                        figures.Add(Rectangle.Enter());
                        break;
                    case "s":
                        figures.Add(Square.Enter());
                        break;
                    case "t":
                        figures.Add(Triangle.Enter());
                        break;
                    case "c":
                        figures.Add(Circle.Enter());
                        break;
                    case "q":
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Нет такого типа фигуры");
                        break;
                }

                Console.WriteLine("\nДобавленные фигуры:");
                foreach (Figure f in figures)
                {
                    f.Print();
                    Console.WriteLine($"Площадь: {f.Area():F2}");
                    Console.WriteLine($"Периметр: {f.Perimeter():F2}");
                    Console.WriteLine();
                }

                Console.Write("Продолжить? (y/n): ");
                flag = Console.ReadLine().ToLower() == "y";

            } while (flag);

            Console.ReadLine();
        }
    }
}


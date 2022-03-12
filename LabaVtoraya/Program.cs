using System;

namespace LabaVtoraya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №2 - Наследование");
            Console.WriteLine("Выполнил - Панин Илья ВПИ - 31\n");

            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник А",
                Width = 15.2,
                Height = 13.7
            };

            Rectangle b = new Rectangle()
            {
                Name = "Прямоугольник Б",
                Width = 5.1,
                Height = 2.8
            };

            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", a.GetArea());

            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", b.GetArea());

            Circle c = new Circle() { Name = "Круг А", Radius = 13 };
            Parallelogram d = new Parallelogram() { Name = "Параллелограм А", Base = 14.7, Height = 32.8 };
            RegularDecagon e = new RegularDecagon() { Name = "Правильный десятиугольник А", Side = 13.4 };
            RegularPentagon f = new RegularPentagon() { Name = "Правильный пятиугольник А", Side = 24.1 };
            Rhomb g = new Rhomb() { Name = "Ромб А", FirstDiagonal = 12.6, SecondDiagonal = 3.3 };
            Square h = new Square() { Name = "Квадрат А", Side = 5.8 };
            Trapezoid j = new Trapezoid() { Name = "Трапеция А", FirstBase = 11.5, SecondBase = 6.2, Height = 4.6 };
            Triangle k = new Triangle() { Name = "Треугольник А", Base = 6.7, Height = 15.3 };

            Console.WriteLine("Название фигуры: {0}", c.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", c.GetArea());

            Console.WriteLine("Название фигуры: {0}", d.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", d.GetArea());

            Console.WriteLine("Название фигуры: {0}", e.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", e.GetArea());

            Console.WriteLine("Название фигуры: {0}", f.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", f.GetArea());

            Console.WriteLine("Название фигуры: {0}", g.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", g.GetArea());

            Console.WriteLine("Название фигуры: {0}", h.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", h.GetArea());

            Console.WriteLine("Название фигуры: {0}", j.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", j.GetArea());

            Console.WriteLine("Название фигуры: {0}", k.Name);
            Console.WriteLine("Площадь фигуры: {0}\n", k.GetArea());

            Console.ReadLine();

        }
    }
}

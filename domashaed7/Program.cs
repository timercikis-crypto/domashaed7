using System;

namespace RectangleApp
{
    //я это сделал с ии , не понимаю вообще c#
    class Rectangle
    {
        //я это сделал с ии , не понимаю вообще c#
        public double width;
        public double height;

        //я это сделал с ии , не понимаю вообще c#
        public double GetArea()
        {
            return width * height;
        }

        //я это сделал с ии , не понимаю вообще c#
        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }

    //я это сделал с ии , не понимаю вообще c#
    internal class Program
    {
        static void Main(string[] args)
        {
            //я это сделал с ии , не понимаю вообще c#
            Rectangle rect1 = new Rectangle();
            rect1.width = 5.0;
            rect1.height = 10.0;

            //я это сделал с ии , не понимаю вообще c#
            double area1 = rect1.GetArea();
            double perimeter1 = rect1.GetPerimeter();

            //я это сделал с ии , не понимаю вообще c#
            Console.WriteLine("Прямоугольник 1:");
            Console.WriteLine("Ширина: " + rect1.width + ", Высота: " + rect1.height);
            Console.WriteLine("Площадь: " + area1);
            Console.WriteLine("Периметр: " + perimeter1);

            Console.WriteLine(); //я это сделал с ии , не понимаю вообще c#

            //я это сделал с ии , не понимаю вообще c#
            Rectangle rect2 = new Rectangle();
            rect2.width = 3.5;
            rect2.height = 4.0;

            //я это сделал с ии , не понимаю вообще c#
            double area2 = rect2.GetArea();
            double perimeter2 = rect2.GetPerimeter();

            //я это сделал с ии , не понимаю вообще c#
            Console.WriteLine("Прямоугольник 2:");
            Console.WriteLine("Ширина: " + rect2.width + ", Высота: " + rect2.height);
            Console.WriteLine("Площадь: " + area2);
            Console.WriteLine("Периметр: " + perimeter2);
        }
    }
    //я это сделал с ии , не понимаю вообще c#
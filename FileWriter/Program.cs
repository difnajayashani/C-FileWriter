using System;
using Shapes;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {

            //circle objects
            Circle circle1 = new Circle(3.5);
            Circle circle2 = new Circle(4.5);
            Circle circle3 = circle1+circle2;

            //rectangle objects
            Rectangle rectangle1 = new Rectangle(10,6);
            Rectangle rectangle2 = new Rectangle(5, 3);
            Rectangle rectangle3 = rectangle1 +rectangle2;

            //squre objects
            Squre squre1 = new Squre(2);
            Squre squre2 = new Squre(4);
            Squre squre3 = squre1 + squre2;

            //triangle objects
            Triangle triangle1 = new Triangle(4.2,1);
            Triangle triangle2 = new Triangle(6,3);
            Triangle triangle3 = triangle1 +triangle2;

           

            using (var fileStream = new FileStream(String.Format("Test.txt"), FileMode.OpenOrCreate))
            using (var streamWriter = new StreamWriter(fileStream))
            {

                streamWriter.WriteLine("CIRCLE 1 area: " + circle1.getArea());
                streamWriter.WriteLine("CIRCLE 2 area: " + circle2.getArea());
                streamWriter.WriteLine("CIRCLE 3 area: " + circle3.getArea());


                streamWriter.WriteLine("RECTANGLE1 area: " + rectangle1.getArea());
                streamWriter.WriteLine("RECTANGLE2 area: " + rectangle2.getArea());
                streamWriter.WriteLine("RECTANGLE3 area: " + rectangle3.getArea());

                streamWriter.WriteLine("SQURE1 area: " + squre1.getArea());
                streamWriter.WriteLine("SQURE2 area: " + squre2.getArea());
                streamWriter.WriteLine("SQURE3 area: " + squre3.getArea());

                streamWriter.WriteLine("TRIANGLE1 area: " + triangle1.getArea());
                streamWriter.WriteLine("TRIANGLE2 area: " + triangle2.getArea());
                streamWriter.WriteLine("TRIANGLE3 area: " + triangle3.getArea());


                //streamWriter.WriteLine(sb.ToString());
                streamWriter.Flush();
                streamWriter.Close();
                Console.ReadLine();
            }

        }
    }
}

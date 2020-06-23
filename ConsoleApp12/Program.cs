using System;

namespace ConsoleApp12
{
    class Program
    {
        
            static void Main(string[] args)
            {
            Triangle tr1 = new Triangle(11,12,13);
            tr1.Display();
            Triangle tr2 = new Triangle(1,5,6);
            tr2.Display();
            Triangle tr3 = new Triangle(3,4,5);
            tr3.Display();
            Console.ReadKey();
            }
        
    }
    class Triangle

    {
        private bool Tr;
        private double A;
        private double B;
        private double C;
        public Triangle(int l1, int l2, int l3)

        {
             A = (Math.Acos((Math.Pow(l2, 2) + Math.Pow(l3, 2) - Math.Pow(l3, 2)) / (2 * l1 * l2))) * (180 / Math.PI);
             B = (Math.Acos((Math.Pow(l1, 2) + Math.Pow(l2, 2) - Math.Pow(l1, 2)) / (2 * l2 * l3))) * (180 / Math.PI);
             C = (Math.Acos((Math.Pow(l3, 2) + Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l3))) * (180 / Math.PI);

            if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))

            {
                Tr = true;
            }

            else
            {
                Tr = false;
            }
        }
        public void Display()

        {
            if (Tr == true)
            {
                Console.WriteLine($"\nКоординаты треугольника \n" + $"A : {A.ToString("##.#")}" + $"\nB : {B.ToString("##.#")}" +$"\nC : {C.ToString("##.#")}");
            }
            else
                Console.WriteLine("\nТреугольник не построить");
            
        }
       
    }
}
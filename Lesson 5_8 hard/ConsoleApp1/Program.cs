using System;

namespace Logic
{
    class Programm
    {
        static void Main(string[] args)
        {
            Circle[] circleArray = new Circle[10];
            Square[] squareArray = new Square[10];
            int i = 0;
            int j = 0;
            double totalSum = 0;

            bool enter = true;
            while (enter)
            {
                Console.WriteLine("Enter 'C' for CIRCLE or 'S' for SQUARE\n ---------------\n Press Q to exit");
                string figure = Console.ReadLine();
                if ((figure == "C")||(figure == "c"))
                {
                    Console.WriteLine("Enter radius circle");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    var circle = new Circle(radius);
                    circleArray[i] = circle;
                    i++;
                }
                else if ((figure == "S") || (figure == "s"))
                {
                    Console.WriteLine("Enter side square");
                    int side = Convert.ToInt32(Console.ReadLine());
                    var square = new Square(side);
                    squareArray[j] = square;
                    j++;
                }

                else
                {
                    //код завеершится если введут любую цифру, кроме S и C
                    //необязательно вводить конкретно Q для выхода
                    for (i = 0; i < circleArray.Length; i++)
                    {
                        totalSum += circleArray[i].GetArea();
                    }

                    foreach (Square square in squareArray)
                    {
                        totalSum += square.GetArea();
                    }
                    Console.WriteLine($"Total area of all entered shapes = {totalSum}");
                    break;
                }
            }

        }
    }
}
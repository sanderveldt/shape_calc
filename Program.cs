using System;

namespace First_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string again = "y";

            while (again == "y")
            {
                Console.WriteLine("What shape do you want to Calculate?\n" +
                                  "You can choose between the following:\n" +
                                  "1. Square\n" +
                                  "2. Rectangle\n" +
                                  "3. Triangle\n" +
                                  "4. Circle\n" +
                                  "5. Quit");

                string shape_input = Console.ReadLine();
                if (int.TryParse(shape_input, out int shape_choice))
                {
                    switch (shape_choice)
                    {
                        case "1":
                            Console.WriteLine("Enter side length in cm:");
                            string input_square_side = Console.ReadLine();
                            if (int.TryParse(input_square_side, out int square_side))
                            {
                                int area = square_side * square_side;
                                Console.WriteLine("The sides are " + side + "cm.\n" +
                                                  "The area of the square is " + area + "cm2.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, please choose a number.")
                            }

                        case "2":
                            Console.WriteLine("Enter short side's length in cm:");
                            string input = Console.ReadLine();


                        default:
                            break;


                    }
                }
            }
        }
    }
}
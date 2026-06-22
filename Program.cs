using System;

namespace Shape_calc
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
                        case 1:
                            Console.WriteLine("Enter side length in cm:");

                            string input_square_side = Console.ReadLine();
                            if (int.TryParse(input_square_side, out int square_side))
                            {
                                int square_area = square_side * square_side;

                                Console.WriteLine("The sides are " + square_side + "cm.");
                                Console.WriteLine("The area of the square is " + square_area + "cm2.\n");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, please choose a number.");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter short side's length in cm:");

                            string rectangle_input1 = Console.ReadLine();
                            if (int.TryParse(rectangle_input1, out int rectangle_side1))
                            {
                                Console.WriteLine("Enter long side's length in cm:");
                                string rectangle_input2 = Console.ReadLine();
                                if (int.TryParse(rectangle_input2, out int rectangle_side2))
                                {
                                    int rectangle_area = rectangle_side1 * rectangle_side2;

                                    Console.WriteLine("The short side is " + rectangle_input1 + "cm.");
                                    Console.WriteLine("The long side is " + rectangle_input2 + "cm.");
                                    Console.WriteLine("The area of the rectangle is " + (rectangle_area) + "cm2.\n");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input, please choose a number.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, please choose a number.");
                            }
                            break;


                        default:
                            break;

                    
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please choose a number");
                }
            }
        }
    }
}
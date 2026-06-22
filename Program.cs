using System;

namespace Shape_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string run = "yes";

            while (run == "yes")
            {
                Console.WriteLine("What shape do you want to Calculate?\n" +
                                  "You can choose between the following:\n" +
                                  "1. Square\n" +
                                  "2. Rectangle\n" +
                                  "3. Triangle\n" +
                                  "4. Circle\n" +
                                  "5. Quit");

                string? shape_input = Console.ReadLine();
                if (int.TryParse(shape_input, out int shape_choice))
                {
                    switch (shape_choice)
                    {
                        case 1:
                            Console.WriteLine("Enter side length in cm:");

                            string? input_square_side = Console.ReadLine();
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

                            string? rectangle_input1 = Console.ReadLine();
                            if (int.TryParse(rectangle_input1, out int rectangle_side1))
                            {
                                Console.WriteLine("Enter long side's length in cm:");

                                string? rectangle_input2 = Console.ReadLine();
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

                        case 3:
                            Console.WriteLine("Enter the base length in cm:");

                            string? base_input1 = Console.ReadLine();
                            if (int.TryParse(base_input1, out int base_side))
                            {
                                Console.WriteLine("Enter the height in cm:");

                                string? height_input = Console.ReadLine();
                                if (int.TryParse(height_input, out int height))
                                {
                                    int triangle_area = (base_side * height) / 2;

                                    Console.WriteLine("The base length is " + base_side + "cm.");
                                    Console.WriteLine("The triangle's height is " + height + "cm.");
                                    Console.WriteLine("The area of the triangle is " + triangle_area + "cm2.\n");
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

                        case 4:
                            Console.WriteLine("Enter the radius in cm.");

                            string? radius_input = Console.ReadLine();
                            if (int.TryParse(radius_input, out int radius))
                            {
                                double pi = 3.14;
                                double circle_area = pi * (radius * radius);

                                Console.WriteLine("The radius is " + radius + "cm.");
                                Console.WriteLine("The area of the circle is " + circle_area + "cm2.\n");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, please choose a number.");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Thank you for using this calculator!");
                            run = "no";
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
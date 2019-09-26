using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        public static int Authenticate_Menu_Selection()
        {
            string userInput = "";
            bool authenticateMenuSelect = false;

            while (authenticateMenuSelect == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("Please select,by entering shown number:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("That's not a valid option,please try again :\n");
                }
                else
                {
                    authenticateMenuSelect = true;
                }

            }

            Console.WriteLine();
            return int.Parse(userInput);

        }
        public static int authenticate_User_Input(string option)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"please enter the{option} of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid option,please try again:\n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("As length and width cannot be less than 0 please try again:\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The{option} of your rectangle:\n");
                }
            }

            return number;

        }


        static void Main(string[] args)
        {
            Nav m = new Nav();
            bool valid_initial_Selection = false;
            string initial_Value;
            int choose;

            while (valid_initial_Selection == false)
            {
                Console.WriteLine("1 = Start RectangleApp with Default values of Length = 7 and Width = 6\n");
                Console.WriteLine("2 = Provide valid Length and Width of rectangle\n");
                Console.WriteLine("Choose a menu item to begin:");
                initial_Value = Console.ReadLine();
                Console.WriteLine();

                if (initial_Value != "1" && initial_Value != "2")
                {
                    Console.WriteLine("That's not a valid value, please try again.\n");
                }
                else if (int.Parse(initial_Value) == 1)
                {
                    valid_initial_Selection = true;
                    int length = 7;
                    int width = 6;

                    Console.WriteLine($"You are selected length = {length} and width = {width}.\n");
                    Nav default_inputs = new Nav(length, width);
                    m = default_inputs;

                }
                else if (int.Parse(initial_Value) == 2)
                {
                    valid_initial_Selection = true;

                    int length;
                    int width;

                    length = authenticate_User_Input("length");
                    width = authenticate_User_Input("width");

                    Console.WriteLine("You provided Length = {0} and Width = {1}.\n", length, width);
                    Nav default_inputs = new Nav(length, width);
                    m = default_inputs;
                }
            }


            choose = Authenticate_Menu_Selection();

            while (choose != 7)
            {
                int myResult;

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Length of Rectangle is: {0}\n", m.Getlength());
                        break;
                    case 2:
                        myResult = authenticate_User_Input("length");
                        m.SetLength(myResult);
                        break;
                    case 3:
                        Console.WriteLine("width of Rectangle is: {0}\n", m.GetWidth());
                        break;
                    case 4:
                        myResult = authenticate_User_Input("width");
                        m.SetWidth(myResult);
                        break;
                    case 5:
                        Console.WriteLine("Perimeter of Rectangle of Lenght: {0} and width: {1} is: {2}\n", m.Getlength(), m.GetWidth(), m.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Area of Rectangle of Lenght: {0} and width: {1} is: {2}\n", m.Getlength(), m.GetWidth(), m.GetArea());
                        break;
                    default:
                        break;
                }

                choose = Authenticate_Menu_Selection();

            }

        }
    }
}

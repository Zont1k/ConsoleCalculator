using System; 

namespace Calculator 
{
    class Program 
    {
        static void Main(string[] args) 
        {

            double firstNumber; 
            double secondNumber = 0; 
            string action; 
            string answer; 

            Console.WriteLine("---------------");
            Console.WriteLine("First number: "); 
            Console.WriteLine("---------------");
            firstNumber = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("---------------");
            Console.WriteLine("Action: %, *, /, +, -, !, @ : ");
            Console.WriteLine("---------------");
            action = Console.ReadLine();

            if (action != "!" && action != "@")
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Second number: ");
                Console.WriteLine("---------------");

                secondNumber = Convert.ToDouble(Console.ReadLine());
            }

            switch (action)
            {
                case "+":
                    answer = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    answer = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    answer = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    answer = (firstNumber / secondNumber).ToString();
                    break;
                case "%":
                    answer = (firstNumber % secondNumber).ToString();
                    break;
                case "!":
                    answer = (GetFactorial(firstNumber)).ToString();
                    break;
                case "@":
                    answer = (Math.Sqrt(firstNumber)).ToString();
                    break;
                default:
                    answer = "You have entered an invalid operation";
                    break;
            }

            Console.WriteLine("Answer: " + answer);
        }

        private static double GetFactorial(double number)
        {
            double result = 1;

            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}

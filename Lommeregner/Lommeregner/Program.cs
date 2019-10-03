using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
    {
    class Program
        {
        static void Main(string[] args) 
            {
            bool end = false;
            string oper;
            string numbers;
            double number1, number2;
            double result;
            string calc;
            do
                {
                Console.Write("please enter number with a comma seperator: ");
                numbers = Console.ReadLine();
                Console.Write("choose an operator to work with (+, -, /, *) or enter end to stop: ");
                oper = Console.ReadLine();
                string[] numbersSplit = numbers.Split(',');
                double.TryParse(numbersSplit[0], out number1);
                double.TryParse(numbersSplit[1], out number2);
                switch (oper)
                    {
                    case "+":
                        result = calculator.Add(number1, number2);
                        calc = $"Calculation: {number1} + {number2} = {result}";
                        Console.Write(calc);
                        Console.ReadLine();
                        break;
                    case "-":
                        result = calculator.Subtract(number1, number2);
                        calc = $"Calculation: {number1} - {number2} = {result}";
                        Console.Write(calc);
                        Console.ReadLine();
                        break;
                    case "/":
                        result = calculator.Divide(number1, number2);
                        calc = $"Calculation: {number1} / {number2} = {result}";
                        Console.Write(calc);
                        Console.ReadLine();
                        break;
                    case "*":
                        result = calculator.Multiply(number1, number2);
                        calc = $"Calculation: {number1} * {number2} = {result}";
                        Console.Write(calc);
                        Console.ReadLine();
                        break;
                    case "end":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("please enter valid information");
                        break;
                    }



                } while (!end);
                calculator.Add(1, 2);
            }
        }
    }

using System;

namespace Calc2
{
    class Program
    {
        public static double x1, x2;
        public static string _operator;
        

        static void Main(string[] args)
        {
            var isActive = true;
            double result = 0;

            while (isActive) {

                // call method which reads keys from console
                ReadValues();              

                switch (_operator)
                {
                    case "+":
                        result = Calculator.Plus(x1, x2);
                        break;
                    case "-":
                        result = Calculator.Minus(x1, x2);
                        break;
                    case "/":
                        result = Calculator.Divide(x1, x2);
                        break;
                    case "*":
                        result = Calculator.Multiply(x1, x2);
                        break;
                    case "%":
                        result = Calculator.Balance(x1, x2);
                        break;
                    case "#":
                        result = Calculator.Sqrt(x1);
                        break;
                }

                Console.WriteLine(result);  
              
                Console.WriteLine("Do you want to proceed? Type Y if yes");
                var key = Console.ReadLine();

                if (key.ToUpper() != "Y".ToUpper())
                {
                    isActive = false;
                }

                //TODO: use dictionary
                // dictionary[_operator].GetResult(x1, x2);
            }
        }
        
        private static void ReadValues()
        {
            Console.WriteLine("Input the first number and click on Enter: ");

            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Would you like Count the sqrt or some thing elese? Type 'R' if root ");

            var key = Console.ReadLine();

            if (key.ToUpper() == "R".ToUpper())
            {

                _operator = "#";
                return;
                
            }
            else
            {
                Console.WriteLine("Input an operator '+', '-', '/', '*', '%' and click on Enter: ");

                _operator = Console.ReadLine();

                Console.WriteLine("Input the second number and click on Enter: ");

                x2 = Convert.ToDouble(Console.ReadLine());
            }         

           
        }

    }

}





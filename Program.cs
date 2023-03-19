using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");

            bool success;
            int operation; 


            while (true)
            {

                try
                {
                    Console.WriteLine("Podaj 1 liczbę:");
                    double number1 = int.TryParse(Console.ReadLine(), out number1);

                    Console.WriteLine("Podaj proszę 2 liczbę:");
                    double number2 = int.TryParse(Console.ReadLine(), out number2);

                    Console.WriteLine("Jaką operację chcesz wykonać? Do wyboru:");
                    Console.WriteLine("\n1. Dodawanie");
                    Console.WriteLine("2. Odejmoawnie");
                    Console.WriteLine("3. Mnożenie");
                    Console.WriteLine("4. Dzielenie");
                    Console.WriteLine("5. Procenty");
                    Console.WriteLine("6. Potęgowanie");
                    Console.WriteLine("7. Pierwiastkowanie\n");
                    
                    do
                    {
                        Console.WriteLine("Wybierz działanie od 1 do 7:");
                        bool success = int.TryParse(Console.ReadLine(),out operation)
                    }
                    
                    
                    
                    
                    
                    
                    var operation = Console.ReadLine();

                   

                    var result = Calculate(number1, number2, operation);

                    Console.WriteLine($"Wynik Twojego działania to: {Math.Round(result, 2)}.\n");

                }
                catch (Exception ex)
                {
                    //logowanie do pliku
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static double GetInput()
        {
            if (!double.TryParse(Console.ReadLine(), out double input))
                throw new Exception("Podana wartość nie jest liczbą.\n");

            return input;
        }

        private static double Calculate(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    {
                        return number1 + number2;
                    }
                case "-":
                    {
                        return number1 - number2;
                    }
                case "*":
                    {
                        return number1 * number2;
                    }
                case "/":
                    {
                        if (number2 == 0) Console.WriteLine("Błąd. Nie można dzielić przez 0.");
                        else Console.WriteLine($"Wynik:" + (number1 / number2));
                        break;
                    }
                case "%":
                    {
                        Console.WriteLine($"Wynik:"+(number1*number2/100)+"%" );
                        break;
                    }
                case "":
                    {
                        int choice;
                        int right;

                        
                        do
                        {
                            Console.Write("Której potęgi chcesz użyć (1 lub 2)?");
                            //tu musi byc zmienna która określa potęge do której chcesz to zrobić 
                            right = int.TryParse(Console.ReadLine(), out choice);

                        }
                        while ((right != 1) && (choice != 2));
                        if (choice == 1)
                            Console.WriteLine($"Wynik:{number1}\u00b2 =" + (number1*number1));
                        
                    }
                    
                case "":
                    {
                    
                        do
                        {
                            Console.Write("")
                        }
                    }
               
                default:
                    throw new Exception("Wybrałeś złą operację!\n");
            }
        }
    }
}

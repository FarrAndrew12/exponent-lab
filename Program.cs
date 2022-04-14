
    public class Program
    {
        public static void Main()
        {
            bool runIt = true;

            while (runIt == true)
            {
                Console.WriteLine("Please enter an integer");
                string integer = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                int whatever = int.Parse(integer);
                Count(whatever);
                Console.WriteLine();
                
                runIt = RunItBack();
            
            }
        }
        public static string GetUserInput(string UIn)
        {
            Console.WriteLine(UIn);
            string input = Console.ReadLine();
            return input;
        }
        public static int Count(int input)
        {
                Console.WriteLine($"Number:\t\tSquared:\tCubed:");
        for (int i = 1; i <= input; i++)
            {
                int UserInS = Squared(i);
                int UserInC = Cubed(i);
                
                Console.WriteLine($"{i}\t\t{UserInS}\t\t{UserInC}");
            } 
          return input;
        }
        public static int Squared(int sq)
        {
            return sq * sq;
        }
        public static int Cubed(int cb)
        {
            return cb * cb * cb;
        }
        public static bool RunItBack()
        {
            string answer = GetUserInput("Would you like to restart the program? y/n").ToLower();
           
        
            if (answer == "y")
            {
            
                return true;
            }
            else if (answer == "n")
            {
            
                Console.WriteLine("Have a Nice Day");
                return false;
            }
            else
            {
            
                Console.WriteLine("My apologies, I didn't quite understand that");
                Console.WriteLine("Let us try that one more time");
               
                return RunItBack();
        }
        
    }
        
    }

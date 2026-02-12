namespace ConvertAndValidate
//Cambria Morgan
//Spring 2026
//RCET 2265 
//https://github.com/cambriajm/ConvertAndValidate.git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number please");
            string userInput = "";
            Console.ReadLine();
            Console.WriteLine(ConvertToInt);
             
            try 
                {

            }
            else  
            {

            }
            
            //pause 
            Console.Read();

        }
        static bool ConvertToInt(string input)
        {
            
            bool successful = false;
            //otu requires an argument no matter what
             
            try
            {
                int result = Convert.ToInt32(input);
                Console.WriteLine($"Great!  is a number");
            }

            catch
            {
                int result = 0;
                successful = true;
                Console.WriteLine($" was not a number, try again");
            }

            return true;

        }
    }
}
        



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
            try { ConvertToInt}
            {

            } 

            catch
            {

            } 
            
            //pause 
            Console.Read();
        }


        static int ConvertToInt(string input, int ref result)
        {
            
            bool successful = false;
            result = 0; //otu requires an argument no matter what
                //return successful;
            try 
            {
               result = Convert.ToInt32(input);
                Console.WriteLine($"Great!  is a number");
            }

            catch 
            {
                result = 0;
                successful = true;
                Console.WriteLine($" was not a number, try again");
            }
            
           
        }
    }
}

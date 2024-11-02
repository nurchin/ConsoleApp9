namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the password: ");
            string Password = Console.ReadLine();
            bool passwordIsRight = ValidatePassword(Password);

         
            if (passwordIsRight)
            {
                Console.WriteLine("Password is valid");
            }

            else {

                Console.WriteLine("Password is invalid");
            }


         }


       
        static bool ValidatePassword(string Password)
        {
            int length = Password.Length;

            if (length >= 8 && 
                char.IsUpper(Password[0]) && 
                Password.Any(char.IsDigit) && 
                Password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return true;
            }

            return false;



        }


    }
}
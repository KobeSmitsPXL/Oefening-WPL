namespace WPL_Demo_oef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Wat in je gebruikersnaam?");
            string userName = Console.ReadLine();
            Console.WriteLine("Password:");
            string userPassword = Console.ReadLine();

            if (userName == "Papa" && userPassword == "Papaisdebeste2000")
            {
                Console.WriteLine("Welkom, admin!");
            }
            
            
        }
    }
}

namespace ConditionStatementHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string? firstName = Console.ReadLine();
            bool isValid = int.TryParse(firstName, out int numberName);
            while (firstName == "" || isValid == true)
            {
                Console.WriteLine("Please enter your actual name.");
                Console.Write("What is your name: ");
                firstName = Console.ReadLine();
                if (firstName != "")
                {
                    isValid = int.TryParse(firstName, out numberName);
                    if (isValid == true)
                    {
                        Console.WriteLine("Please enter a actual name.");
                    }
                    else
                    {
                        break;
                    }
                }
            };
            if (firstName.ToLower() == "tim" ||  firstName.ToLower() == "timothy")
            {
                Console.WriteLine("Hello Professor");
            }
            else
            {
                Console.WriteLine("Hello Student.");
            }

        }
    }
}

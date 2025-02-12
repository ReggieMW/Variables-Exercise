namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? readResult;
            string nounPlace = "Church";
            int firstNumber = 0;
            char classGrade = 'A';
            bool goodPrice = true;
            double icecreamPrice = 0.99;
            decimal icecreamTax = 0.10m;

            Console.WriteLine("Would you like to play a game? (Y/N)");

            readResult = Console.ReadLine();
            if (readResult != "N")
            {
                Console.WriteLine("Enter a place:");
                nounPlace = Console.ReadLine();
                Console.WriteLine("Enter a number:");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your class grade:");
                classGrade = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number:");
                icecreamPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number:");
                icecreamTax = decimal.Parse(Console.ReadLine());

                Console.WriteLine(
                    $"{nounPlace} sells the best ice cream. They have been in business for {firstNumber} years. Ice cream enthusiast magazine gave their scoops an {classGrade}. You can get a scoop for yourself for ${icecreamPrice} plus {icecreamTax} tax.\n");
            }

            if (icecreamPrice > 5)
            {
                goodPrice = false;
                Console.WriteLine("That's too expenseive.");
            }
            else
            {
                goodPrice = true;
                Console.WriteLine("That's a good price! I'll take 3 scoops!");
            }
        }
    }
}
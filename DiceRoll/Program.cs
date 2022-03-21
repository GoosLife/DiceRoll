namespace DiceRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            char userInput2;

            char userInput;

            static void RollDice()
            {
                Console.Clear();

                Random random = new Random();
                int diceRoll = random.Next(1, 7);

                switch (diceRoll)
                {
                    case 1:
                        Console.WriteLine("Du slog en etter");
                        break;
                    case 2:
                        Console.WriteLine("Du slog en to'er");
                        break;
                    case 3:
                        Console.WriteLine("Du slog en tre'er");
                        break;
                    case 4:
                        Console.WriteLine("Du slog en firer");
                        break;
                    case 5:
                        Console.WriteLine("Du slog en femmer");
                        break;
                    case 6:
                        Console.WriteLine("Du slog en sekser");
                        break;
                }
            }

            do
            {
                RollDice();
                userInput = Console.ReadKey().KeyChar;
            }
            while (userInput != 'X');
        }
    }
}
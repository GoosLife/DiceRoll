namespace DiceRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userInput;

            static void RollDice()
            {
                Console.Clear();

                Random random = new Random();
                int diceRoll = random.Next(1, 7);

                switch (diceRoll)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du slog en etter.");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Du slog en to'er.");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Du slog en tre'er.");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Du slog en firer.");
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Du slog en femmer.");
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Du slog en sekser.");
                        break;
                }
            }

            do
            {
                RollDice();
                userInput = Console.ReadKey().KeyChar;
            }
            while (userInput != 'x');
        }
    }
}
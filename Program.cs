namespace GamePatternMeshup
{
    class Program
    {
        static void Main()
        {
            ShowPossibilities();

            var input = System.Console.ReadLine();

            while (input != "exit")
            {
                switch (input)
                {
                    case "command pattern":
                        System.Console.Clear();

                        var commandPattern = new CommandPatternDemo();
                        commandPattern.Execute();

                        System.Console.Clear();
                        ShowPossibilities();

                        break;

                    default:
                        ShowPossibilities();
                        break;
                }

                input = System.Console.ReadLine();
            }
            
        }

        private static void ShowPossibilities()
        {
            System.Console.WriteLine(
                  "You can try out the following demos by typing in their name:" + System.Environment.NewLine
                + "   command pattern" + System.Environment.NewLine

                + System.Environment.NewLine
                + "If you want to close the program type in 'exit'." + System.Environment.NewLine

                + System.Environment.NewLine
                + "What would you like to try out?"
            );
        }
    }
}

namespace DrivingSimulation.Utils.UserConsole
{
	public class ConsoleManager : IConsoleManager
    {
        public void Clear()
        {
            Console.Clear();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public void Write(string value)
        {
            Console.Write(value);
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public string ReadWithRetry(Func<string, bool> validationFunction, bool allowRetry)
        {
            string userInput = "";
            var run = true;

            do
            {
                userInput = Console.ReadLine();

                var valid = validationFunction(userInput);

                if (!allowRetry || valid)
                {
                    run = false;
                }
            }
            while (run);

            return userInput;
        }

    }
}


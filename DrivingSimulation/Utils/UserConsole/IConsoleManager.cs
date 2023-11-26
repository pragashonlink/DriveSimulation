using System;
namespace DrivingSimulation.Utils.UserConsole
{
	public interface IConsoleManager
	{
        void Write(string value);
        void WriteLine(string value);
        string ReadWithRetry(Func<string, bool> validationFunction, bool allowRetry);
        string ReadLine();
        ConsoleKeyInfo ReadKey();
        void Clear();
    }
}


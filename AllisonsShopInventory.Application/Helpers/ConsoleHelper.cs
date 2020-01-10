using System;

namespace AllisonsShopInventory.Helpers
{
    public static class ConsoleHelper
    {
        public static string ReadString(string RequestMessage)
        {
            Console.Write(RequestMessage);

            return Console.ReadLine();
        }

        public static int ReadInt(string RequestMessage, string ErrorMessage)
        {
            Console.Write(RequestMessage);

            int Output;

            while (!int.TryParse(Console.ReadLine(), out Output))
            {
                Console.WriteLine(ErrorMessage);
            }

            return Output;
        }

        public static bool ReadBool(string RequestMessage)
        {
            Console.Write($"{RequestMessage} [Y/N]");

            ConsoleKey response;

            do
            {
                response = Console.ReadKey(true).Key;
            }
            while (response != ConsoleKey.Y && response != ConsoleKey.N);

            Console.WriteLine();

            return (response == ConsoleKey.Y);
        }
        
        public static void WriteHorizontalRule()
        {
            Console.WriteLine("-----------------");
        }
    }
}
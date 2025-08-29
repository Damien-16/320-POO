namespace escargot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string snake = "_@_ö";
            int PositionActu = 2;
            Console.CursorVisible = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(PositionActu, 10);
                Console.WriteLine(snake);
                Console.SetCursorPosition(PositionActu - 1, 10);
                Console.WriteLine(" ");
                Console.SetCursorPosition(PositionActu, 10);
                PositionActu++;
                Thread.Sleep(50);
            } while (PositionActu < 30);
            Console.WriteLine("____");



        }
    }
}

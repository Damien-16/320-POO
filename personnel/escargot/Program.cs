namespace escargot
{
    internal class Program
    {
        static void Main(string[] args)
        {



            snail snail = new snail();

            Console.CursorVisible = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(snail._position
                , 10);
                Console.WriteLine(snail._skin);
                Console.SetCursorPosition(snail._position - 1, 10);
                Console.WriteLine(" ");
                Console.SetCursorPosition(snail._position, 10);
                snail._position++;
                Thread.Sleep(500);
            } while (snail._position < 30);

            Console.WriteLine("____");

        }
    }
    class snail
    {
        public string _color = "Blue";
        public int _position = 2;
        public string _skin = "_@_ö";
    }
}

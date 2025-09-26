namespace TestDrone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using System;

class Program
        {
            static char[,] board = new char[3, 3];
            static char currentPlayer = 'X';

            static void Main()
            {
                InitBoard();
                while (true)
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine($"Joueur {currentPlayer}, à toi de jouer. Entre la ligne et la colonne (1-3) séparées par un espace:");

                    var input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                        continue;

                    string[] parts = input.Trim().Split();
                    if (parts.Length != 2
                        || !int.TryParse(parts[0], out int row)
                        || !int.TryParse(parts[1], out int col)
                        || row < 1 || row > 3 || col < 1 || col > 3)
                    {
                        Console.WriteLine("Entrée invalide. Appuie sur une touche pour réessayer...");
                        Console.ReadKey();
                        continue;
                    }

                    row--; col--; // passage en indices 0-based

                    if (board[row, col] != ' ')
                    {
                        Console.WriteLine("Case déjà occupée. Appuie sur une touche pour réessayer...");
                        Console.ReadKey();
                        continue;
                    }

                    board[row, col] = currentPlayer;

                    if (IsWinner(currentPlayer))
                    {
                        Console.Clear();
                        PrintBoard();
                        Console.WriteLine($"Le joueur {currentPlayer} a gagné !");
                        if (AskReplay()) ResetGame(); else break;
                        continue;
                    }

                    if (IsBoardFull())
                    {
                        Console.Clear();
                        PrintBoard();
                        Console.WriteLine("Match nul !");
                        if (AskReplay()) ResetGame(); else break;
                        continue;
                    }

                    SwitchPlayer();
                }
            }

            static void InitBoard()
            {
                for (int r = 0; r < 3; r++)
                    for (int c = 0; c < 3; c++)
                        board[r, c] = ' ';
            }

            static void PrintBoard()
            {
                Console.WriteLine("   1   2   3");
                for (int r = 0; r < 3; r++)
                {
                    Console.WriteLine("  ---+---+---");
                    Console.Write($"{r + 1} ");
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write($"| {board[r, c]} ");
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("  ---+---+---");
            }

            static bool IsWinner(char player)
            {
                // lignes
                for (int r = 0; r < 3; r++)
                    if (board[r, 0] == player && board[r, 1] == player && board[r, 2] == player)
                        return true;

                // colonnes
                for (int c = 0; c < 3; c++)
                    if (board[0, c] == player && board[1, c] == player && board[2, c] == player)
                        return true;

                // diagonales
                if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) return true;
                if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player) return true;

                return false;
            }

            static bool IsBoardFull()
            {
                for (int r = 0; r < 3; r++)
                    for (int c = 0; c < 3; c++)
                        if (board[r, c] == ' ') return false;
                return true;
            }

            static void SwitchPlayer()
            {
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }

            static bool AskReplay()
            {
                Console.WriteLine("Rejouer ? (o = oui / n = non)");
                while (true)
                {
                    var k = Console.ReadKey(true).KeyChar;
                    if (k == 'o' || k == 'O') return true;
                    if (k == 'n' || k == 'N') return false;
                }
            }

            static void ResetGame()
            {
                InitBoard();
                currentPlayer = 'X';
            }
        }


    }
}
}
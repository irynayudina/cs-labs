using System;

namespace lab1csVar5
{
    class Program
    {
        public static void GetPosition(ref int  m, ref int n)
        {
            Console.Write("Введите позицию ладьи по горизонтали: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("по вертикали: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public static void PrintChess(Char [,] chess)
        {
            for (int x = 0; x < chess.GetLength(0); x++)
            {
                for(int u= 0; u < chess.GetLength(1); u++)
                {
                    Console.Write(chess[x,u] + "  ");
                }
                Console.WriteLine();
            }
        }
        public static void MakeChessDesk(Char [,] chess)
        {
            for (int s = 0; s < chess.GetLength(0); s++)
            {
                //chess[s] = new String[8];
                for (int f = 0; f < chess.GetLength(1); f++)
                {
                    chess[s,f] = '1';
                }
            }
        }
        public static void PlaceTheRook(Char [,] chess, int m, int n)
        {
            for (int i = 0; i < chess.GetLength(0); i++)
            {
                for (int t = 0; t < chess.GetLength(1); t++)
                {
                    if (i == (m - 1))
                    {
                        chess[i,t] = '*';
                    }
                    if (t == (n - 1))
                    {
                        chess[i,t] = '*';
                    }
                }
            }
            chess[(m - 1),(n - 1)] = 's';
        }
        static void Main(string[] args)
        {
            int n=0, m=0;
            Char[,] chess = new Char[8,8];
            MakeChessDesk(chess);
            GetPosition(ref m, ref n);
            PlaceTheRook(chess, m, n);
            PrintChess(chess);           
        }
    }
}

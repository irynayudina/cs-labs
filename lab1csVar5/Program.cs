using System;

namespace lab1csVar5
{
    class Program
    {
        public static void GetPosition(ref int  m, ref int n)
        {
            Console.Write("Введите позицию фигуры по горизонтали: ");
            m = Convert.ToInt32(Console.ReadLine())-1;
            Console.Write("по вертикали: ");
            n = Convert.ToInt32(Console.ReadLine())-1;
        }
        public static Char GetFigure()
        {
            Console.WriteLine("Выберите фигуру слон 'S' или ладья 'L'");
            return Char.Parse(Console.ReadLine());
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
                    if (i == m)
                    {
                        chess[i,t] = '*';
                    }
                    if (t == n)
                    {
                        chess[i,t] = '*';
                    }
                }
            }
            chess[m,n] = 'L';
        }
        public static void PlaceTheSlon(Char[,] chess, int m, int n)
        {
            int i = 0;
            while(i<chess.GetLength(0))
            {
                if ((m - i) >= 0 && (n + i) <= 7)
                {
                    chess[m - i, n + i] = '*';
                }
                if ((m + i) <=7 && (n - i) >= 0)
                {
                    chess[m + i, n - i] = '*';
                }
                if((m-i) >=0 && (n - i) >= 0)
                {
                    chess[m - i, n - i] = '*';
                }
                if((m+i) <=7 && (n + i) <= 7)
                {
                    chess[m + i, n + i] = '*';
                }
                
                i++;
            }
            chess[m, n] = 'S';
        }
        static void Main(string[] args)
        {
            int n=0, m=0;
            Char[,] chess = new Char[8,8];
            MakeChessDesk(chess);
            GetPosition(ref m, ref n);
            if (GetFigure() == 'L')
            {
                PlaceTheRook(chess, m, n);
            }
            else
            {
                PlaceTheSlon(chess, m, n);
            }
            PrintChess(chess);           
        }
    }
}

using System;
using System.Diagnostics;

namespace lab2
{

    public enum FormOfStudy
    {
        FullTime,
        PartTime,
        Distance
    }
    class Program
{
        
    static void Main(string[] args)
    {
            //for test {
            GraduateStudent s = new GraduateStudent();
            s.Student.Name = "x";
            s.AddArticles(new Article(), new Article());
            Console.WriteLine($"resized article has length: {s.Articles.Length}");
            Console.WriteLine(s.ToString());
            Article a = new Article();
            Console.WriteLine(a.ToString());
            Console.WriteLine($"amount of articles: {s.Articles.Length}");
            Person human = new Person();
            Console.WriteLine(human.ToString());
            human.ChangeBirthday = 1999;
            Console.WriteLine(human.ToString());
            // } for test
            int m, n;
            Console.WriteLine(@"Enter m and n using following separators: ' ', ',', '.', ':', '\t'");
            string inp = Console.ReadLine();
            string[] mn = inp.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            m = EnterPositiveInt(mn[0]);
            n = EnterPositiveInt(mn[1]);
            Person[] arr1dimention = new Person[m * n];
            Person[,] arr2dimention = new Person[m, n];
            Person[][] arrStepped = new Person[m][];
            Create2dstepped(m, n, arrStepped);
            int sssssum = 0;///testing sum of all elements of stepped array
            for (int i =0; i<m; i++)
            {
                Console.WriteLine($"arrStepped[{i}][{arrStepped[i].Length}]");
                sssssum += arrStepped[i].Length;
            }
            Console.WriteLine($" sum of elements of stepped array{ sssssum}");
            for(int i = 0; i < arr1dimention.Length; i++)
            {
                arr1dimention[i] = new Person();
            }
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    arr2dimention[i, k] = new Person();
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < arrStepped[i].Length; k++)
                {
                    arrStepped[i][k] = new Person();
                }
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < arr1dimention.Length; i++)
            {
                arr1dimention[i].Name = "I";
            }
            stopWatch.Stop();
            TimeSpan ts1d = stopWatch.Elapsed;
            stopWatch.Start();
            for (int i = 0; i < arr2dimention.GetLength(0); i++)
            {
                for (int k = 0; k < arr2dimention.GetLength(1); k++)
                {
                    arr2dimention[i, k].Name = "I";
                }
            }
            stopWatch.Stop();
            TimeSpan ts2d = stopWatch.Elapsed;
            stopWatch.Start();
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < arrStepped[i].Length; k++)
                {
                    arrStepped[i][k].Name = "I";
                }
            }
            stopWatch.Stop();
            TimeSpan tss = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts1d.Hours, ts1d.Minutes, ts1d.Seconds,
            ts1d.Milliseconds / 10);
            Console.WriteLine("RunTime of 1 dimentional array " + ts1d);
            Console.WriteLine("RunTime of 2 dimentional array " + ts2d);
            Console.WriteLine("RunTimes of stepped array" + tss);
    }

        private static void Create2dstepped(int m, int n, Person[][] arrStepped)
        {
            Random rand = new Random();
            int sum = m * n - 1;//чтобы убедиться что ддлинна последнего массива хотя-бы 1
            int sumremain = sum;
            for (int i = 0; i < arrStepped.Length; i++)
            {
                sumremain = sum;
                for (int k = 0; k < i; k++)
                {
                    sumremain = sumremain - arrStepped[k].Length;
                    if (sumremain < 0)
                    {
                        sumremain = 0;
                    }
                }
                int d = (m / 2) == 0 ? 1 : m / 2 ;
                int r = sumremain/d > 1 ? rand.Next(1, sumremain / d) : 1;//деление m/2 обеспечивает болеее мелкие рандомные числа
                arrStepped[i] = new Person[r];
                arrStepped[arrStepped.Length - 1] = new Person[1+sumremain];
            }
        }
        private static int EnterPositiveInt()
        {
            int m = -1;
            string tmp = Console.ReadLine();
            while (!(int.TryParse(tmp, out m)) || m<1)
            {
                Console.Write("Введите целое положительное число ");
                tmp = Console.ReadLine();
            }
            return m;
        }
        static int EnterPositiveInt(string tmp)
        {
            int m = -1;
            while (!(int.TryParse(tmp, out m)) || m < 1)
            {
                Console.Write("Введите целое положительное число ");
                tmp = Console.ReadLine();
            }
            return m;
        }
}
}



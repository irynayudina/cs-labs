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
            
            ////////////////Common task///////////////////////

            int m, n;
            A: Console.WriteLine(@"Enter m and n using following separators: ' ', ',', '.', ':', '\t'");
            string inp = Console.ReadLine();
            string[] mn = inp.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            while (mn.Length < 2)
            {
                goto A;
            }
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

            ////////Individual task////////////////////Variant 6

            GraduateStudent graduateStudent = new GraduateStudent();
            Console.WriteLine("\n\n\nInitial value of Graduate student created with constructor without parameters\n\n\n");
            Console.WriteLine(graduateStudent.ToString());
            Console.WriteLine("\n\n\nEach property of Graduate student is modified, except articles\n\n\n");
            graduateStudent.Student = new Person("Maria", "Shewchenko", new DateTime(2000, 04, 04));
            graduateStudent.Supervisor = new Person("Artem", "Melnyk", new DateTime(1990, 09, 01));
            graduateStudent.Speciality = "Applied mathematics";
            graduateStudent.LearningYear = 2025;
            graduateStudent.Form = (FormOfStudy)2;
            Console.WriteLine(graduateStudent.ToShortString());
            Console.WriteLine("\n\n\nInitial value of Graduate student created, using constructor with parameters\n\n\n");
            GraduateStudent graduate = new GraduateStudent(new Person("Lydia", "Yud", new DateTime(1999, 02, 23)), new Person("Maxym", "Boyko", new DateTime(1989, 03, 24)), "Information technology", (FormOfStudy)1, 2026);
            Console.WriteLine(graduate.ToString());
            graduate.AddArticles(new Article(),
                new Article("Information technology of evaluation and improvement the quality of cluster analysis", "Lviv Polytechnic Publishing House", new DateTime(2012, 08, 24)),
                new Article("Information technology for the analysis of the dynamics of the reaction rate of the operator", "Lviv Polytechnic Publishing House", new DateTime(2014, 07, 19)),
                new Article("article 1", "place 1", new DateTime(2009, 03, 07)),
                new Article("article 2", "place 2", new DateTime(2010, 04, 17)),
                new Article("article 3", "place 3", new DateTime(2013, 02, 12)),
                new Article("article 4", "place 4", new DateTime(2010, 06, 29)),
                new Article("article 5", "place 5", new DateTime(2012, 01, 14)),
                new Article("article 6", "place 6", new DateTime(2014, 07, 19)),
                new Article("article 7", "place 7", new DateTime(2014, 02, 26)),
                new Article("article 8", "place 8", new DateTime(2014, 07, 19)),
                new Article("article 9", "place 9", new DateTime(2014, 03, 19)),
                new Article("article 10", "place 10", new DateTime(2014, 07, 19)),
                new Article("article 11", "place 11", new DateTime(2015, 09, 21)),
                new Article("article 12", "place 12", new DateTime(2014, 07, 19)),
                new Article("article 13", "place 13", new DateTime(2016, 08, 14)),
                new Article("article 14", "place 14", new DateTime(2014, 07, 19)),
                new Article("article 15", "place 15", new DateTime(2017, 04, 06)),
                new Article("article 16", "place 16", new DateTime(2014, 07, 19)),
                new Article("article 17", "place 17", new DateTime(2014, 03, 29)),
                new Article("article 18", "place 18", new DateTime(2014, 07, 19)),
                new Article("article 19", "place 19", new DateTime(2018, 03, 19)),
                new Article("article 20", "place 20", new DateTime(2024, 03, 09)),
                new Article("article 21", "place 21", new DateTime(2014, 01, 20)),
                new Article("article 22", "place 22", new DateTime(2014, 07, 19)),
                new Article("article 23", "place 23", new DateTime(2018, 07, 19)),
                new Article("article 24", "place 24", new DateTime(2014, 07, 19)),
                new Article("article 25", "place 25", new DateTime(2018, 12, 24)),
                new Article("article 26", "place 26", new DateTime(2014, 07, 19)),
                new Article("article 27", "place 27", new DateTime(2019, 11, 08)),
                new Article("article 28", "place 28", new DateTime(2014, 07, 19)),
                new Article("article 29", "place 29", new DateTime(2011, 07, 19)),
                new Article("article 30", "place 30", new DateTime(2014, 07, 19)),
                new Article("article 31", "place 31", new DateTime(2010, 01, 04)));
            Console.WriteLine(graduate.ToString());
            Console.WriteLine(graduate.LastArticle);


            int m1, n1;
        B: Console.WriteLine(@"Enter m and n using following separators: ' ', ',', '.', ':', '\t'");
            string inp1 = Console.ReadLine();
            string[] mn1 = inp1.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            while (mn1.Length < 2)
            {
                goto B;
            }
            m1 = EnterPositiveInt(mn1[0]);
            n1 = EnterPositiveInt(mn1[1]);
            Article[] arr1dimentiona = new Article[m * n];
            Article[,] arr2dimentiona = new Article[m, n];
            Article[][] arrSteppeda = new Article[m][];
            Create2dstepped(m, n, arrSteppeda);
            int sssssuma = 0;///testing sum of all elements of stepped array
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"arrStepped[{i}][{arrSteppeda[i].Length}]");
                sssssuma += arrSteppeda[i].Length;
            }
            Console.WriteLine($" sum of elements of stepped array{ sssssuma}");
            for (int i = 0; i < arr1dimentiona.Length; i++)
            {
                arr1dimentiona[i] = new Article();
            }
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    arr2dimentiona[i, k] = new Article();
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < arrSteppeda[i].Length; k++)
                {
                    arrSteppeda[i][k] = new Article();
                }
            }

            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            for (int i = 0; i < arr1dimentiona.Length; i++)
            {
                arr1dimentiona[i].Name = "I";
            }
            stopWatch1.Stop();
            TimeSpan ts1da = stopWatch1.Elapsed;
            stopWatch1.Start();
            for (int i = 0; i < arr2dimentiona.GetLength(0); i++)
            {
                for (int k = 0; k < arr2dimentiona.GetLength(1); k++)
                {
                    arr2dimentiona[i, k].Name = "I";
                }
            }
            stopWatch1.Stop();
            TimeSpan ts2da = stopWatch1.Elapsed;
            stopWatch1.Start();
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < arrSteppeda[i].Length; k++)
                {
                    arrSteppeda[i][k].Name = "I";
                }
            }
            stopWatch1.Stop();
            TimeSpan tssa = stopWatch1.Elapsed;
            string elapsedTimea = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts1da.Hours, ts1da.Minutes, ts1da.Seconds,
            ts1da.Milliseconds / 10);
            Console.WriteLine("RunTime of 1 dimentional array " + ts1da);
            Console.WriteLine("RunTime of 2 dimentional array " + ts2da);
            Console.WriteLine("RunTimes of stepped array" + tssa);

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
                int r = sumremain/d > 1 ? rand.Next(1, sumremain / d) : 1;
                arrStepped[i] = new Person[r];
                arrStepped[arrStepped.Length - 1] = new Person[1+sumremain];
            }
        }
        private static void Create2dstepped(int m, int n, Article[][] arrStepped)
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
                int d = (m / 2) == 0 ? 1 : m / 2;
                int r = sumremain / d > 1 ? rand.Next(1, sumremain / d) : 1;
                arrStepped[i] = new Article[r];
                arrStepped[arrStepped.Length - 1] = new Article[1 + sumremain];
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



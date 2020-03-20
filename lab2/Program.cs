﻿using System;
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
            
            Article a = new Article();
            Console.WriteLine(a.ToString());
            Person human = new Person();
            Console.WriteLine(human.ToString());
            human.ChangeBirthday = 1999;
            Console.WriteLine(human.ToString());
            // } for test
            int m, n;
            Console.WriteLine(@"Enter m and n using following separators: ' ', ',', '.', ':', '\t'");
            string inp = Console.ReadLine();
            //safe entering
            //m = EnterPositiveInt();
            //n = EnterPositiveInt();
            string[] mn = inp.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            m = Convert.ToInt32(mn[0]);
            n = Convert.ToInt32(mn[1]);
            Person[] arr1dimention = new Person[m * n];
            Person[,] arr2dimention = new Person[m, n];
            Person[][] arrStepped = new Person[m][];
            Create2dstepped(m, n, arrStepped);
            for(int i =0; i<m; i++)
            {
                Console.WriteLine($"arrStepped[{i}][{arrStepped[i].Length}]");
            }

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
            ////////////////////individual tasks variant 6
            

        }

        private static void Create2dstepped(int m, int n, Person[][] arrStepped)
        {
            Random rand = new Random();
            for (int i = 0; i < arrStepped.Length; i++)
            {
                int sum = m * n-1;
                int sumremain = sum;
                for (int k = 0; k < i; k++)
                {
                    sumremain = sumremain - arrStepped[k].Length;
                    if (sumremain < 0)
                    {
                        sumremain = 0;
                    }
                }
                int r = sumremain > 0 ? rand.Next(1, sumremain/2) : 0;
                arrStepped[i] = new Person[r];
                arrStepped[arrStepped.Length - 1] = new Person[1+sumremain];
            }
        }
        //unused function
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
}
}



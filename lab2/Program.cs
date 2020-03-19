using System;

namespace lab2
{
    public class Person
    {
        private string name;
        private string lastName;
        private DateTime birthday;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        //Additional unnecessary function
        public int Age()
        {
            int bYear, nYear;
            bYear = Birthday.Year;
            nYear = DateTime.Today.Year;
            return (nYear - bYear);
        }
        public int ChangeBirthday
        {            
            get { return Birthday.Year; }
            set { Birthday = new DateTime(value, Birthday.Month, Birthday.Day); }
        }
        public Person(string name, string lastName, DateTime birthday)
        {
            Name = name;
            LastName = lastName;
            Birthday = birthday;
        }
        public Person()
        {
            Name = "Iryna";
            LastName = "Yudina";
            Birthday = new DateTime(2001, 01, 27);
        }
        override public string ToString()
        {
            return ($"Information about subject:\n Name: {this.Name}\n Last Name: {LastName}\n" +
                $" Date of birthday: {Birthday}\n" +
                $" Age: {((DateTime.Today).Subtract(Birthday)).Days/365} or {Age()}");
        }
        public virtual string ToShortString()
        {
            return ($"{Name} {LastName}");
        }
    }

class Program
{
    static void Main(string[] args)
        {

            Person human = new Person();
            Console.WriteLine(human.ToString());
            human.ChangeBirthday = 1999;
            Console.WriteLine(human.ToString());
            int m, n;
            m = EnterPositiveInt();
            n = EnterPositiveInt();
            int[] arr1dimention = new int[m * n];
            int[,] arr2dimention = new int[m, n];
            int[][] arrStepped = new int[m][];
            Create2dstepped(m, n, arrStepped);
            for(int i =0; i<m; i++)
            {
                Console.WriteLine(arrStepped[i].Length);
            }
        }

        private static void Create2dstepped(int m, int n, int[][] arrStepped)
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
                arrStepped[i] = new int[r];
                arrStepped[arrStepped.Length - 1] = new int[1+sumremain];
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
    }
}



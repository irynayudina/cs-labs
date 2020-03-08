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

        }
}
}



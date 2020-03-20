using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Article
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public Article(string name, string place, DateTime date)
        {
            Name = name;
            Place = place;
            Date = date;
        }
        public Article()
        {
            Name = "Basics of OOP";
            Place = "DNU";
            Date = new DateTime(2019, 03, 20);
        }
        public override string ToString()
        {
            return ($"Information about article:\n Name: {Name}\n" +
                $" Date of publishing: {Date}\n" +
                $" Place of publishing: {Place}");
        }
    }
}

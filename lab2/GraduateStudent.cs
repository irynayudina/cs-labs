using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class GraduateStudent
    {
        private Person student;
        private Person supervisor;
        private string speciality;
        private FormOfStudy form;
        private int learningYear;
        private Article[] articles;
        public Person Student
        {
            get;set;
        }
        public Person Supervisor
        {
            get; set;
        }
        public string Speciality
        {
            get; set;
        }
        public FormOfStudy Form
        {
            get; set;
        }
        public int LearningYear
        {
            get; set;
        }
        public Article[] Articles
        {
            get { return articles; }
            set { }
        }
        public GraduateStudent(Person student, Person supervisor, string speciality, FormOfStudy form, int learningYear)
        {
            Student = student;
            Supervisor = supervisor;
            Speciality = speciality;
            Form = form;
            LearningYear = learningYear;
        }
        public GraduateStudent()
        {
            Student = new Person();
            Supervisor = new Person();
            Speciality = "Software engineering";
            Form = 0;
            LearningYear = 2020;
        }
        public Article LastArticle
        {
            get { return Articles[Articles.Length-1]; }
        }
    }
}

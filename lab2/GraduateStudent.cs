using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            get { return student; }
            set { student = value; }
        }
        public Person Supervisor
        {
            get { return supervisor; }
            set { supervisor = value; }
        }
        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }
        public FormOfStudy Form
        {
            get { return form; }
            set { form = value; }
        }
        public int LearningYear
        {
            get { return learningYear; }
            set { learningYear = value; }
        }
        public Article[] Articles
        {
            get { return articles; }
            set { articles = value; }
        }
        public Article LastArticle
        {
            get {
                if (Articles[Articles.Length - 1] != null)
                {
                    Articles.OrderBy(a => a.Date).ToArray();
                    return (Articles[Articles.Length - 1]);
                }
                else { return null; }
                }
        }
        public GraduateStudent(Person student, Person supervisor, string speciality, FormOfStudy form, int learningYear)
        {
            Student = student;
            Supervisor = supervisor;
            Speciality = speciality;
            Form = form;
            LearningYear = learningYear;
            Articles = new Article[0];
            this.articles = new Article[0];
        }
        public GraduateStudent()
        {
            Student = new Person();
            Supervisor = new Person();
            Speciality = "Software engineering";
            Form = 0;
            LearningYear = 2020;
            Articles = new Article[0];
            this.articles = new Article[0];
        }       
         public void AddArticles(params Article[] p)
         {
             int initialLength = this.articles.Length;
             Array.Resize(ref this.articles, this.articles.Length + p.Length);
            //p.CopyTo(this.articles, initialLength-1);
             for(int i = initialLength; i<this.articles.Length; i++)
             {
                 this.articles[i] = p[i-initialLength];
             }
         }
        public override string ToString()
        {
            string allInfo = ($"Student: {Student.ToString()}, Supervisor: {Supervisor.ToString()}," +
                $" Speciality: {Speciality}, FormOfstudy: {Form}," +
                $"LearningYear: {LearningYear}, Articles: ");
            foreach (Article i in this.articles) { allInfo += i.ToString(); }
            return allInfo;
        }
        public virtual string ToShortString()
        {
            return ($"Student {Student}, Supervisor {Supervisor}, Speciality {Speciality}, FormOfstudy {Form}," +
                $"LearningYear {LearningYear}");
        }
    }
}

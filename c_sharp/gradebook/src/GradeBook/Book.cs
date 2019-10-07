using System;
using System.Collections.Generic;

namespace GradeBook
{

    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class Book : NamedObject
    {
        private List<double> grades;
        public string Name{
            get; 
            set;
        }
        public event GradeAddedDelegate GradeAdded;
        public const string CATEGORY = "Science";
        
        public Book(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(char letter){
            switch(letter){
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade){
            if(grade <= 100 && grade >= 0){
                grades.Add(grade);
                if(GradeAdded != null){
                    GradeAdded(this, new EventArgs());
                }
            }
            else{
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public Statistics GetStatistics(){
            var results = new Statistics();
            results.Average = 0.0;
            results.High = double.MinValue;
            results.Low = double.MaxValue;
            results.Length = grades.Count;

            foreach(var grade in grades){
                results.Low = Math.Min(grade, results.Low);
                results.High = Math.Max(grade, results.High);
                results.Average += grade;
            }
            results.Average /= grades.Count;

            switch(results.Average){
                case var d when d >= 90.0:
                    results.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    results.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    results.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    results.Letter = 'D';
                    break;
                default:
                    results.Letter = 'F';
                    break;
            }
            return results;
        }
    }
}
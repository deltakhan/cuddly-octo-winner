using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class InMemoryBook : Book, IBook
    {
        private List<double> grades;

        public override event GradeAddedDelegate GradeAdded;
        public const string CATEGORY = "Science";
        
        public InMemoryBook(string name) : base(name)
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

        public override void AddGrade(double grade){
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

        public override Statistics GetStatistics(){
            var results = new Statistics(); 

            foreach(var grade in grades){
                results.Add(grade);
            }

            return results;
        }
    }
}
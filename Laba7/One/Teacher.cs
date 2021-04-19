using System;

namespace Laba7
{
    public class Teacher : Person
    {
        protected const int salaryRate = 7000;
        protected string subjectName;
        protected DateTime dateOfEmployment;
        protected bool isCurator;

        public Teacher()
        {
        }

        public Teacher(string firsName, string surname, int age, string subjectName, DateTime dateOfEmployment, bool isCurator) : base(firsName, surname, age)
        {
            this.subjectName = subjectName;
            this.dateOfEmployment = dateOfEmployment;
            this.isCurator = isCurator;
        }

        public Teacher(string firsName, string surname, string subjectName, DateTime dateOfEmployment) : base(firsName, surname)
        {
            this.subjectName = subjectName;
            this.dateOfEmployment = dateOfEmployment;
        }

        public string SubjectName
        {
            get => subjectName;
            set => subjectName = value;
        }

        public DateTime DateOfEmployment
        {
            get => dateOfEmployment;
            set => dateOfEmployment = value;
        }

        public bool IsCurator
        {
            get => isCurator;
            set => isCurator = value;
        }

        public override int GetExperience()
        {
            return DateTime.Now.Year - dateOfEmployment.Year;
        }

        public virtual double GetSalary()
        {
            return isCurator
                ? Math.Floor(GetExperience() * salaryRate * 0.15)
                : Math.Floor(GetExperience() * salaryRate * 0.13);
        }
        
        public override string Show()
        {
            return base.Show() + 
                   $"\n{nameof(subjectName)}: {subjectName}, " +
                   $"\n{nameof(dateOfEmployment)}: {dateOfEmployment}, " +
                   $"\n{nameof(isCurator)}: {isCurator}" +
                   $"\nsalary: {GetSalary()}";
        }
    }
}
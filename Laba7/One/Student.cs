using System;

namespace Laba7
{
    public class Student : Person
    {
        private DateTime dateOfAddmission;
        private double avarageGrade;
        private bool hasCourseWork;

        public Student()
        {
        }

        public Student(string firsName, string surname, int age, DateTime dateOfAddmission, double avarageGrade, bool hasCourseWork) : base(firsName, surname, age)
        {
            if ((DateTime.Now.Year - dateOfAddmission.Year) > 6.5 
                || (DateTime.Compare(DateTime.Now, dateOfAddmission) == -1))
            {
                throw new Exception("Невірна дата вступу!");
            }
            this.dateOfAddmission = dateOfAddmission;
            this.avarageGrade = avarageGrade;
            this.hasCourseWork = hasCourseWork;
        }

        public Student(string firsName, string surname, DateTime dateOfAddmission) : base(firsName, surname)
        {
            this.dateOfAddmission = dateOfAddmission;
        }

        public DateTime DateOfAddmission
        {
            get => dateOfAddmission;
            set => dateOfAddmission = value;
        }

        public double AvarageGrade
        {
            get => avarageGrade;
            set => avarageGrade = value;
        }

        public bool HasCourseWork
        {
            get => hasCourseWork;
            set => hasCourseWork = value;
        }

        public override string Show()
        {
            return base.Show() + 
                   $"\n{nameof(dateOfAddmission)}: {dateOfAddmission}, " +
                   $"\n{nameof(avarageGrade)}: {avarageGrade}, " +
                   $"\n{nameof(hasCourseWork)}: {hasCourseWork}";
        }


        public void GetCourse()
        {
            int experience = GetExperience();
            if (experience <= 9)
            {
                Console.WriteLine("Студент першого курсу");
            }
            else if (experience <= 21)
            {
                Console.WriteLine("Студент другого курсу");
            }
            else if (experience <= 33)
            {
                Console.WriteLine("Студент третього курсу");
            }
            else if (experience <= 45)
            {
                Console.WriteLine("Студент четвертого курсу");
            }
            else if (experience <= 57)
            {
                Console.WriteLine("Студент п'ятого курсу");
            }
            else if (experience <= 69)
            {
                Console.WriteLine("Студент шостого курсу");
            }
        }
        public override int GetExperience()
        {
            return ((DateTime.Now.Year - dateOfAddmission.Year) * 12) 
                + DateTime.Now.Month - dateOfAddmission.Month;
        }
    }
}
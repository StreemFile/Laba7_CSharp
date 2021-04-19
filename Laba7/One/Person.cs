using System;

namespace Laba7
{
    public abstract class Person
    {
        protected string firsName;
        protected string surname;
        protected int age;

        public Person()
        {
        }

        public Person(string firsName, string surname)
        {
            this.firsName = firsName;
            this.surname = surname;
        }

        public Person(string firsName, string surname, int age)
        {
            this.firsName = firsName;
            this.surname = surname;
            this.age = age;
        }
        
        
        ~Person()
        {
            Console.WriteLine("Person was destroyed");
        }

        public string FirsName
        {
            get => firsName;
            set => firsName = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public virtual string Show()
        {
            return $"{nameof(firsName)}: {firsName}," +
                   $"\n{nameof(surname)}: {surname},"+ 
                   $"\n{nameof(age)}: {age}";
        }

        public abstract int GetExperience();
        
    }
}
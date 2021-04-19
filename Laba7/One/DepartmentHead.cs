using System;

namespace Laba7
{
    public class DepartmentHead : Teacher
    {
        private string department;
        private ScientificDegree scientificDegree;
        private string someInfo;

        public DepartmentHead()
        {
        }

        public DepartmentHead(string firsName, string surname, int age, string subjectName, DateTime dateOfEmployment, bool isCurator, string department, ScientificDegree scientificDegree, string someInfo) : base(firsName, surname, age, subjectName, dateOfEmployment, isCurator)
        {
            this.department = department;
            this.scientificDegree = scientificDegree;
            this.someInfo = someInfo;
        }

        public DepartmentHead(string firsName, string surname, int age, string subjectName, DateTime dateOfEmployment, bool isCurator, string department, ScientificDegree scientificDegree) : base(firsName, surname, age, subjectName, dateOfEmployment, isCurator)
        {
            this.department = department;
            this.scientificDegree = scientificDegree;
        }

        public string Department
        {
            get => department;
            set => department = value;
        }

        public ScientificDegree ScientificDegree
        {
            get => scientificDegree;
            set => scientificDegree = value;
        }

        public string SomeInfo
        {
            get => someInfo;
            set => someInfo = value;
        }

        public override double GetSalary()
        {
            if (isCurator)
            {
                switch (scientificDegree)
                {
                    case ScientificDegree.Docent:
                        return Math.Floor(base.GetExperience() 
                                          * salaryRate 
                                          * 0.19);
                    case ScientificDegree.SeniorResearcher:
                        return Math.Floor(base.GetExperience() 
                                          * salaryRate 
                                          * 0.21);
                    case ScientificDegree.Professor:
                        return Math.Floor(base.GetExperience() 
                                          * salaryRate 
                                          * 0.23);
                    case ScientificDegree.PhilosphyDoctor:
                        return Math.Floor(base.GetExperience() 
                                          * salaryRate 
                                          * 0.25);
                    default: 
                        return Math.Floor(base.GetExperience() 
                                          * salaryRate 
                                          * 0.17);
                }
            }
            switch (scientificDegree)
                {
                    case ScientificDegree.Docent:
                        return Math.Floor(base.GetExperience() 
                                          * salaryRate 
                                          * 0.17);
                    case ScientificDegree.SeniorResearcher:
                        return Math.Floor(base.GetExperience() 
                                          * salaryRate 
                                          * 0.19);
                    case ScientificDegree.Professor:
                        return Math.Floor(base.GetExperience() 
                                          * salaryRate 
                                          * 0.21);
                    case ScientificDegree.PhilosphyDoctor:
                        return Math.Floor(base.GetExperience() 
                                          * salaryRate 
                                          * 0.23);
                    default: 
                        return Math.Floor(base.GetExperience() 
                                               * salaryRate 
                                               * 0.15);
                }
        }

        public override string Show()
        {
            return base.Show() + 
                   $"\n{nameof(department)}: {department}, " +
                   $"\n{nameof(scientificDegree)}: {scientificDegree}, " +
                   $"\n{nameof(someInfo)}: {someInfo}";;
        }
    }
}
using System;

namespace PRELIM_A1_BSIT31A3_RED_DANIEL_RAFAEL_B.Models
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Student
    {
        private string _firstName;
        private string _lastName;

        public Student()
        {
            _firstName = "N/A";
            _lastName = "N/A";
            Title = "Mr/Ms";
            Course = "Undefined";
            Section = "Undefined";
            Birthday = DateTime.MinValue;
            Gender = Gender.Unknown;
        }

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            Title = "Mr/Ms";
            Course = "Undefined";
            Section = "Undefined";
            Birthday = DateTime.MinValue;
            Gender = Gender.Unknown;
        }

        public string FirstName => _firstName;
        public string LastName => _lastName;

        public string Title { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public DateTime Birthday { get; set; }

        public Gender Gender { get; private set; }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        public void SetGender(Gender gender)
        {
            Gender = gender;
        }

        public string FullName => $"{Title} {FirstName} {LastName}";

        public int Age
        {
            get
            {
                if (Birthday == DateTime.MinValue) return 0;

                var today = DateTime.Today;
                var age = today.Year - Birthday.Year;
                if (Birthday.Date > today.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }
    }
}
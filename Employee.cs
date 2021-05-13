using System;

namespace EventDemo
{
    public class Employee
    {

        private DateTime _birthDate;
        public event Action OnBirthday;


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                if (_birthDate.Date == DateTime.Today)
                {
                    OnBirthday += Employee_OnBirthday;
                    OnBirthday();
                }

            }
        }

        private void Employee_OnBirthday()
        {
            Console.WriteLine("Happy Birthday");
        }
    }
}

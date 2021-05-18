using System;

namespace EventDemo
{
    public class Employee
    {
        private DateTime _birthDate;
        public event EventHandler OnBirthDay;


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
                    if (OnBirthDay is not null)
                    {
                        OnBirthDay(this, EventArgs.Empty);
                    }
                }

            }
        }
    }
}

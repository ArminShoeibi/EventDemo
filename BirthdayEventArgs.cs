using System;

namespace EventDemo
{
    public class BirthdayEventArgs : EventArgs
    {
        public DateTime BirthDate { get; set; }
    }
}

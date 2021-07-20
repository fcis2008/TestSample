using System;
using System.ComponentModel.DataAnnotations;

namespace TestSample.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsSubscribed { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
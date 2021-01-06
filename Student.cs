using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string EnrolledCourse { get; set; }
        public string Status { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}

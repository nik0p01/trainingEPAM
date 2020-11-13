using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    internal class Student : IEquatable<Student>
    {
        private string _fullName;
        private string _email;
        public Student(string email)
        {
            if (email == null || email.IndexOf('@') < email.IndexOf('.'))
            {
                throw new Exception("There is not an email");
            }
            _email = email;
            _fullName = email.Remove(email.IndexOf('@')).Replace('.', ' ');
        }
        public Student(string name, string surname)
        {
            if (name == null || surname == null)
            {
                throw new Exception("There is not name and surname");
            }
            _fullName = name + " " + surname;
            _email = $"{name.ToLower()}.{surname.ToLower()}@epam.com";
        }

        public bool Equals(Student student)
        {
            if (student == null)
                return false;
            return (student._fullName ?? string.Empty).ToLower() == (_fullName.ToLower() ?? string.Empty) && (student._email ?? string.Empty).ToLower() == (_email ?? string.Empty).ToLower();
        }
        public override int GetHashCode()
        {
            return ((_fullName ?? string.Empty).ToLower().GetHashCode() + (_email ?? string.Empty).ToLower().GetHashCode()) / 2;
        }

        public override string ToString()
        {
            return _fullName + " " + _email;
        }

    }
}

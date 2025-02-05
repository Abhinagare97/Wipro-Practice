using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

    }
}


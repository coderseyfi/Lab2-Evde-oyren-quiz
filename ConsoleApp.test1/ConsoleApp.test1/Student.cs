using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.test1
{
    class Student
    {
        public int id { get; set; }
        public string Name;
        public string surname;
        public string Address;

        public static int Counter = 0;
        public Student()
        {
            Counter++;
            id = Counter;
        }
        public override string ToString()
        {
            return $"{id} {Name}{surname}{Address}";
        }
    }
}

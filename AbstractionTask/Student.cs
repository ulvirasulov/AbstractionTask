using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTask
{
    public class Student
    {
        private static int _id = 1;

        public Student(string fullName, int point)
        {
            Id = _id++;
            FullName = fullName;
            Point = point;
        }

        public int Id { get; }
        public string FullName { get; set; }
        public int Point { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine($"id: {Id}, full name: {FullName}, point: {Point}");
        }
    }
}

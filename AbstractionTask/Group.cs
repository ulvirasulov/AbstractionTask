using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTask
{
    public class Group
    {
        public string GroupNo { get; private set; }
        public int StudentLimit { get; private set; }
        private Student[] students = new Student[0];
        private int currentStudentCount;

        public Group(string groupNo, int studentLimit)
        {
            if (studentLimit < 5 && studentLimit > 18)
            {
                Console.WriteLine("Student sayi 5den kicik ve ya 18den boyuk ola bilmez");
            }
            if (!CheckGroupNo(groupNo))
            {
                Console.WriteLine("grup adi 2 boyuk herf ve 3 reqemden ibaret olmalidi");
            }
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            students = new Student[StudentLimit];
            currentStudentCount = 0;
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 5)
            {
                return false;
            }

            if (!(groupNo[0] >= 'A' && groupNo[0] <= 'Z' && groupNo[1] >= 'A' && groupNo[1] <= 'Z'))
            {
                return false;
            }

            if (!(groupNo[2] >= '0' && groupNo[2] <= '9' && groupNo[3] >= '0' && groupNo[3] <= '9' && groupNo[4] >= '0' && groupNo[4] <= '9'))
            {
                return false;
            }

            return true;
        }
        public bool AddStudent(Student student)
        {
            if (currentStudentCount >= StudentLimit)
            {
                Console.WriteLine("Student maksimum sayini kece bilmezsiz.");
                return false;
            }

            students[currentStudentCount] = student;
            currentStudentCount++;
            return true;
        }
        public Student GetStudent(int id)
        {
            for (int i = 0; i < currentStudentCount; i++)
            {
                if (students[i].Id == id)
                {
                    return students[i];
                }
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            Student[] result = new Student[currentStudentCount];

            for (int i = 0; i < currentStudentCount; i++)
            {
                result[i] = students[i];
            }

            return result;
        }
    }
}
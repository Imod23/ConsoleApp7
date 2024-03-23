using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Student
    {

        public int StudentIndex { get; set; }
        public string StudentName { get; set; }

        public string Address { get; set; }

        public int StudentMark { get; set; }

        public Student(int aStudentIndex, string aStudentName, string aAddress, int aStudentMark)
        {
            StudentIndex = aStudentIndex;
            StudentName = aStudentName;

            Address = aAddress;
            StudentMark = aStudentMark;

        }


        public bool HasPassed()
        {
            if (StudentMark >= 60)
            {
                return true;

            }


            return false;

        }




    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTask
{
    partial class Group
    {
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }

        public void AddStudent(Student stu)
        {
            if(MaxCount!= students.Length)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = stu;
                //Console.WriteLine($"{stu} elave olundu");
            }
            else
            {
                Console.WriteLine($"{Name} qrupu doludur.Mksimum telebe sayi - {MaxCount}. {stu} elave olunmadi");
            }
        }

        public void StudentList()
        {
            Console.WriteLine($"Qrup - {Name}:");
            foreach (Student stu in students)
            {
                Console.WriteLine(stu);
            }
        }

        public Student FindStudent(int id)
        {
            Student result = null;
            foreach (Student stu in students)
            {
                if (stu.Id == id)
                {
                    result = stu;
                    break;
                }
            }
            return result;
        }
    }
}

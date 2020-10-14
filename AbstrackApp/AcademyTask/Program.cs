using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Aqil", "Beshirov");
            Student s2 = new Student("Kamran", "Haciyev");
            Student s3 = new Student("Ayshen", "Quliyeva");
            Student s4 = new Student("Nigar", "Kamran");
            Student s5 = new Student("Rufet", "Zulfiqarov");


            Group p509 = new Group("P509", 2);
            Group p507 = new Group("P507", 18);

            p509.AddStudent(s1);
            p509.AddStudent(s2);
            p507.AddStudent(s3);
            p507.AddStudent(s4);
            p507.AddStudent(s5);

            //p507.StudentList();

            if (p509.FindStudent(2) != null)
            {
                Console.WriteLine(p509.FindStudent(2));
            }
            else
            {
                Console.WriteLine("Bele id-li telebe yoxdur");
            }
            
            //p509.StudentList();
        }
    }
}

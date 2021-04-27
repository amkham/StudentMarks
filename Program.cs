using System;
using System.Collections.Generic;

namespace StudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EducationalInstitut> instituts = new List<EducationalInstitut>();
            List<Student> students = new List<Student>();

            instituts.Add(new EducationalInstitut { Name = "Универ1", Category = true });
            instituts.Add(new EducationalInstitut { Name = "Универ2", Category = false });
            instituts.Add(new EducationalInstitut { Name = "Универ3", Category = false });

            for (int i = 0; i < 10; i++)
            {

                foreach (var inst in instituts)
                {
                    if (inst.Category == true)
                    {
                        students.Add(new Student($"Петров{i}", inst, new Random().Next(1, 10)));
                    }
                    else { students.Add(new Student($"Петров{i}", inst, new Random().Next(1, 5))); 
                    }
                    
                }
            }

            Report report = new Report(students);

            foreach (var i in report.getStudentList())
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("Средний балл: " + report.markAverage());
            

            
           
        }
    }
}

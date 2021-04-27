using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMarks
{
    class Report
    {
        private List<Student> students = new List<Student>();
       

        public Report(List<Student> students)
        {
            this.students = students;
          
        }

        //Получить список студентов
        public List<Student> getStudentList()
        {
           

            foreach (var i in students)
            {
                if (i.EducationalInstitut.Category == true)
                {

                    if (i.Mark <= 3)
                    {
                        i.Mark = 2;
                    }
                    if ((i.Mark > 3) &&(i.Mark<=5))
                    {
                        i.Mark = 3;
                    }
                    if ((i.Mark > 5) && (i.Mark <= 7))
                    {
                        i.Mark = 4;
                    }
                    if ((i.Mark > 7) && (i.Mark <= 10))
                    {
                        i.Mark = 5;
                    }
                }
            }

            return students;
        }


        // Средний бал
       public double markAverage()
        {
            
            int result = 0;
            int coll = 0;

            foreach (var i in students)
            {
                if (i.EducationalInstitut.Category == true)
                {

                    result += i.Mark;
                    coll++;
                   
                }
            }

            return result/coll;
        }
    }
}

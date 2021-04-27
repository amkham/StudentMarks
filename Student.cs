using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMarks
{
    class Student
    {
        private string surName;
        private string educInstitutionName;
        private EducationalInstitut educationalInstitut;
        private int mark;
      

      
     

      

        public Student(string surName, EducationalInstitut educationalInstitut, int mark)
        {
            SurName = surName;
            EducInstitutionName = educationalInstitut.Name;
            EducationalInstitut = educationalInstitut;
            Mark = mark;
        }

       
        public string EducInstitutionName { get => educInstitutionName; set => educInstitutionName = value; }
        public int Mark { get => mark; set => mark = value; }
        public string SurName { get => surName; set => surName = value; }
        internal EducationalInstitut EducationalInstitut { get => educationalInstitut; set => educationalInstitut = value; }

        public override string ToString()
        {
            return "Фамилия: " + SurName + " Заведение: "+ EducInstitutionName + " Оценка: " + Mark;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMarks
{
   
    class EducationalInstitut
    {
        private string name;

        /// <summary>
        /// True если 10-я система, False если 5-ти
        /// </summary>
        private bool category;

        

        public EducationalInstitut(string name, bool category)
        {
            Name = name;
            Category = category;
        }

        public EducationalInstitut()
        {
            Name = "";
            Category = false;
        }

        public string Name { get => name; set => name = value; }
        public bool Category { get => category; set => category = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Konsola
{
    internal class StudentManager
    {
        public List<Student> StudentList { get; init; }

        private double[] Scores = [2.0, 3.0, 3.5, 4.0, 4.5, 5.0];

        public StudentManager()
        {
            StudentList = new List<Student>();
        }

        public bool TryDeleteStudentById(int id)
        {
            Student? student = StudentList.Find(x => x.Id == id);
            if (student != null)
                return StudentList.Remove(student);
            return false;
        }

        public bool TryAddStudentValidated(string firstName, string secondName, double avrageScore)
        {
            if (firstName.Contains(" ") || secondName.Contains(" ") || !Scores.Contains(avrageScore))
                return false;

            // TO WARTO NA EGZAMIN ZAPAMIĘTAĆ, ALE FAKT, SCIĄGNIĘTE Z INTERNETU (NA SZCZĘŚCIE TYLKO TO).
            TextInfo textInfo = new CultureInfo("pl-PL", false).TextInfo;

            StudentList.Add(new Student(textInfo.ToTitleCase(firstName), textInfo.ToTitleCase(secondName), avrageScore));
            return true;
        }

        public List<Student> StudentListSortedByAvrageScore()
        {
            return StudentList
                .OrderBy(student => student.AvrageScore)
                .Reverse()
                .ToList();
        }

        public List<Student> FindBySecondName(string secondName)
        {
            return StudentList.FindAll(student => student.SecondName == secondName);
        }

        public double AvrageFromAllStudents()
        {
            return StudentList.Average(studnet => studnet.AvrageScore);
        }
    }
}

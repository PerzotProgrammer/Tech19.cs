using System;
using System.Collections.Generic;
using System.Text;

namespace Konsola
{
    internal class Student
    {
        private static int nextId = 0;
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string SecondName { get; init; }
        public double AvrageScore { get; init; }

        public Student(string firstName, string secondName, double avrageScore)
        {
            Id = nextId++;
            FirstName = firstName;
            SecondName = secondName;
            AvrageScore = avrageScore;
        }
    }
}

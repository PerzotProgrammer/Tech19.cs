using System;
using System.Collections.Generic;
using System.Text;

namespace Konsola
{
    internal class StudentMenu
    {
        private StudentManager studentManager;

        public StudentMenu()
        {
            studentManager = new StudentManager();
            Console.WriteLine("Witamy w menadżerze zarządzania studentami");
        }

        public void PrintMainMenu()
        {
            bool loop = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("1. Dodać studenta");
                Console.WriteLine("2. Usunąć studenta");
                Console.WriteLine("3. Wyświetlić wszystkich studentów");
                Console.WriteLine("4. Znaleźć po nazwisku");
                Console.WriteLine("5. Posortować malejąco po średniej");
                Console.WriteLine("6. Wyświetlić średnią");
                Console.WriteLine("7. Zamknąć program");

                Console.Write("Twoja opcja: ");

                bool isValid = int.TryParse(Console.ReadLine(), out int option);

                if (!isValid || option < 1 || option > 7) Console.WriteLine("Niepoprawna opcja!");
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    switch (option)
                    {
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            DeleteStudent();
                            break;
                        case 3:
                            DisplayAllStudents();
                            break;
                        case 4:
                            FindBySName();
                            break;
                        case 5:
                            SortByAvg();
                            break;
                        case 6:
                            DisplayAvg();
                            break;
                        case 7:
                            loop = false;
                            Console.WriteLine("Cześć!");
                            break;
                    }
                }

            } while (loop);

        }

        private void AddStudent()
        {
            Console.Write("Podaj imie: ");
            string studentFName = Console.ReadLine() ?? string.Empty;
            Console.Write("Podaj nazwisko: ");
            string studentSName = Console.ReadLine() ?? string.Empty;
            Console.Write("Podaj średnią (przecinkowo): ");
            string studentAvg = Console.ReadLine() ?? string.Empty;

            if (studentFName == string.Empty || studentSName == string.Empty || !double.TryParse(studentAvg, out double avg) ||
                !studentManager.TryAddStudentValidated(studentFName, studentSName, avg)) Console.WriteLine("Coś poszło nie tak");
            else Console.WriteLine("Student dodany");
        }

        private void DeleteStudent()
        {
            Console.Write("Podaj id studenta: ");

            if (!int.TryParse(Console.ReadLine(), out int id) || !studentManager.TryDeleteStudentById(id))
                Console.WriteLine("Coś poszło nie tak");
            else Console.WriteLine("Student usunięty");
        }

        private void DisplayAllStudents()
        {
            Console.WriteLine("ID\t\tIMIE\t\tNAZWISKO\t\tŚREDNIA");

            foreach (Student student in studentManager.StudentList)
            {
                Console.WriteLine($"{student.Id}\t\t{student.FirstName}\t\t{student.SecondName}\t\t{student.AvrageScore}");
            }
        }

        private void FindBySName()
        {
            Console.Write("Podaj nazwisko: ");
            string studentSName = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("ID\t\tIMIE\t\tNAZWISKO\t\tŚREDNIA");
            foreach (Student student in studentManager.FindBySecondName(studentSName))
            {
                Console.WriteLine($"{student.Id}\t\t{student.FirstName}\t\t{student.SecondName}\t\t{student.AvrageScore}");
            }
        }

        private void SortByAvg()
        {
            Console.WriteLine("ID\t\tIMIE\t\tNAZWISKO\t\tŚREDNIA");
            foreach (Student student in studentManager.StudentListSortedByAvrageScore())
            {
                Console.WriteLine($"{student.Id}\t\t{student.FirstName}\t\t{student.SecondName}\t\t{student.AvrageScore}");
            }
        }

        private void DisplayAvg()
        {
            Console.WriteLine($"Średnia uczniów to: {studentManager.AvrageFromAllStudents()}");
        }
    }
}

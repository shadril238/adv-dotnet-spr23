//shadril238

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void PrintList(List<Student> students)
        {
            foreach(Student student in students)
            {
                student.Show();
            }
        }
        static void Main(string[] args)
        {
            int[] marks = new int[] { 30, 47, 68, 76, 93, 69, 96, 99, 100 };
            int[] aplus = new int[marks.Length];
            int count = 0;
            //General Approach
            foreach(int mark in marks)
            {
                if (mark >= 80)
                {
                    aplus[count++] = mark;
                }
            }
            //Using LINQ
            var aplus_linq=(from mark in marks where mark>=80 select mark).ToArray();

            List<Student> students = new List<Student>();
            Random rand = new Random();
            for(int i = 1; i <= 100; i++)
            {
                students.Add(new Student()
                {
                    Roll = i,
                    Name = "Student " + i,
                    Marks = rand.Next(10, 101)
                });
            }
            Console.WriteLine("-------Students(" +students.Count + ")---------");
            PrintList(students);

            Console.WriteLine("-----------------");
            var marks75 = (from s in students
                           where s.Marks >= 75
                           select s).ToList();

            Console.WriteLine("-------75(" + marks75.Count + ")---------");
            PrintList(marks75);

            Console.WriteLine("-----------------");
            var marks75110 = (from s in students
                              where s.Marks >= 75 && s.Roll <= 10
                              select s).ToList();
            Console.WriteLine("-------75(" + marks75110.Count + ")---------");
            PrintList(marks75110);

            Console.WriteLine("-----------------");
        }
    }
}

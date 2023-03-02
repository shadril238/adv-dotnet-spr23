using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }   
        public double Marks { get; set; }
        public void Show()
        {
            Console.WriteLine("Roll: " + Roll);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Marks: " + Marks);
            Console.WriteLine("----------------");
        }
    }
}

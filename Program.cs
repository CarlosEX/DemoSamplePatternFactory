using System;
using DemoSamplePatternFactory.Factory;
using DemoSamplePatternFactory.Interfaces;

namespace DemoSamplePatternFactory {
    class Program {
        static void Main(string[] args) {
            IStudent student = StudentFactory.Create("Ana");
            Console.WriteLine(student.Name);
        }
    }
}

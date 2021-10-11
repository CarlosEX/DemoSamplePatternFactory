using DemoSamplePatternFactory.Entities;
using DemoSamplePatternFactory.Interfaces;

namespace DemoSamplePatternFactory.Factory
{
    public class StudentFactory
    {
        public static IStudent Create(string name){
            return new Student(name);
        }
    }
}
using System;
using DemoSamplePatternFactory.Interfaces;

namespace DemoSamplePatternFactory.Entities {
    public class Student : IStudent
    {
        public Student(string name) {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; private set; }
    }
}

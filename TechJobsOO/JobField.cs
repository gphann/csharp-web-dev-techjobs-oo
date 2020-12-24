using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public string Value { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public JobField(string name, object employerName, object employerLocation, object jobType, object jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = (Employer)employerName;
            EmployerLocation = (Location)employerLocation;
            JobType = (PositionType)jobType;
            JobCoreCompetency = (CoreCompetency)jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField jobField &&
                   Id == jobField.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

    }
}

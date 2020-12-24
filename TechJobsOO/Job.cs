using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, object employerName, object employerLocation, object jobType, object jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = (Employer)employerName;
            EmployerLocation = (Location)employerLocation;
            JobType = (PositionType)jobType;
            JobCoreCompetency = (CoreCompetency)jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string fieldEmpty = "Data not available.";
            if (Name == "")
            {
                Name = fieldEmpty;
            }

            if (EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = fieldEmpty;
            }

            if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = fieldEmpty;
            }

            if (JobType.Value == "")
            {
                JobType.Value = fieldEmpty;
            }

            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = fieldEmpty;
            }
           
            return $"\nID: {Id} \nName: {Name} \nEmployer: {EmployerName.Value} \nLocation: {EmployerLocation.Value} \nPosition Type: {JobType.Value} \nCore Competency: {JobCoreCompetency.Value}";

        }

    }
}

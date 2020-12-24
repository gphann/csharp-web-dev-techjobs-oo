using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;
using System.Collections.Generic;

namespace TechJobsTest
{
    [TestClass]
    public class JobTest
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job = new Job();
            Job test_job2 = new Job();
            Assert.IsTrue(test_job.Id != test_job2.Id && test_job.Id + 1 == test_job2.Id);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(Equals(job1, job2));
        }

        //[TestMethod]
        //public void JobObjectShouldReturnStringWithBlankLine()
        //{
        //    Job tj = new Job();
        //    Assert.AreEqual("     ", tj.ToString()); 
        //}

        [TestMethod]
        public void JobObjectShouldReturnStringWithFieldLabelsAndData()
        {
            Job tj2 = new Job("Ice cream tester", new Employer("Tasty"), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            //tj2.EmployerName.Value = "";
            tj2.Name = "Cake";
            string testingOutput = $"\nID: {tj2.Id} \nName: {tj2.Name} \nEmployer: {tj2.EmployerName.Value} \nLocation: {tj2.EmployerLocation.Value} \nPosition Type: {tj2.JobType.Value} \nCore Competency: {tj2.JobCoreCompetency.Value}";
            Assert.AreEqual(testingOutput, tj2.ToString());
        }

        [TestMethod]
        public void JobObjectShouldReturnDataNotAvailableIfEmptyField()
        {
            Job tj3 = new Job("Ice cream testers", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            //tj3.EmployerName.Value = "Data not available.";
            string testOutput = $"\nID: {tj3.Id} \nName: {tj3.Name} \nEmployer: Data not available. \nLocation: {tj3.EmployerLocation.Value} \nPosition Type: {tj3.JobType.Value} \nCore Competency: {tj3.JobCoreCompetency.Value}";
            Assert.AreEqual(testOutput, tj3.ToString());
        }

    }
}

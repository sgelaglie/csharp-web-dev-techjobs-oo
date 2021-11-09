using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;
namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //Create two Job objects using the empty constructor. Use Assert.AreEqual, Assert.IsTrue, or Assert.IsFalse to test that the ID values for the two objects are NOT the same and differ by 1.

        [TestMethod]
        public void TestSettingJobId()
        {
            Job Job1 = new Job();
            Job Job2 = new Job();
            Assert.IsTrue(Job2.Id == Job1.Id + 1);
        }
        [TestMethod]
        public void TestJobConstractorSetsAllFields()
        {
            Job testJob = new Job("Product tester",
                       new Employer("ACME"),
                       new Location("Desert"),
                       new PositionType("Quality control"),
                       new CoreCompetency("Persistence"));

            Assert.IsTrue(testJob.EmployerName.Value == "Acme");
            Assert.IsTrue(testJob.EmployerLocation.Value == "Desert");
            Assert.IsTrue(testJob.JobType.Value == "quality control");
            Assert.IsTrue(testJob.JobCoreCompetency.Value == "persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester",
                       new Employer("ACME"),
                       new Location("Desert"),
                       new PositionType("Quality control"),
                       new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester",
                       new Employer("ACME"),
                       new Location("Desert"),
                       new PositionType("Quality control"),
                       new CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Equals(job2));

        }

    }
}

    










    

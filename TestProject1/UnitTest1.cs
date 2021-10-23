using Microsoft.VisualStudio.TestTools.UnitTesting;

using TechJobsOO;
    namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Create two Job objects using the empty constructor. Use Assert.AreEqual, Assert.IsTrue, or Assert.IsFalse to test that the ID values for the two objects are NOT the same and differ by 1.
       


        [TestMethod]
        public void TestMethod1()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.AreEqual(testJob1.Id , testJob2.Id);
        }
    }
}



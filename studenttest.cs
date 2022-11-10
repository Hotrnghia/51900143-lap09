using StudentServiceLib;
namespace Teststudent
{
    [TestClass]
    public class studenttest
    {
        [TestMethod]
        public void Test_score8_student()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Hào";
            s.Age = 12;
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);

        }

        [TestMethod]
        public void Test_score7andhalf_student()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Hào";
            s.Age = 12;
            s.Score = 7.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);

        }


        [TestMethod]
        public void Test_score7_student()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Hào";
            s.Age = 12;
            s.Score = 7.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);

        }

        [TestMethod]
        public void Test_score5_student()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Hào";
            s.Age = 12;
            s.Score = 5.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);

        }


    }
}
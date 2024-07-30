using ToyRobot;
namespace ToyRobotTest
{

    public class RobotTests
    {
        private Robot robot;
        [SetUp]
        public void Setup()
        {
            robot = new Robot();
        }

        [Test]
        public void TestValidPlacing()
        {
            robot.Place(0, 0, Facing.North);
            Assert.That(robot.Report(), Is.EqualTo("Robot is at (0,0) facing North"));
        }

        [Test]
        public void TestInvalidPlacing()
        {
            robot.Place(5, 5, Facing.North);
            Assert.That(robot.Report(), Is.EqualTo("Robot is at (0,0) facing North"));
        }

        public void TestValidMove()
        {
            robot.Place(0, 0, Facing.North);
            robot.Move();
            Assert.That(robot.Report(), Is.EqualTo("Robot is at (0,1) facing North"));
        }

        [Test]
        public void TestInvalidMove()
        {
            robot.Place(4, 4, Facing.East);
            robot.Move();
            Assert.That(robot.Report(), Is.EqualTo("Robot is at (4,4) facing East"));
        }

        [Test]
        public void TestLeft()
        {
            robot.Place(0, 0, Facing.West);
            robot.Left();
            Assert.That(robot.Report(), Is.EqualTo("Robot is at (0,0) facing South"));
        }

        [Test]
        public void TestRight()
        {
            robot.Place(0, 0, Facing.West);
            robot.Right();
            Assert.That(robot.Report(), Is.EqualTo("Robot is at (0,0) facing North"));
        }
    }
}
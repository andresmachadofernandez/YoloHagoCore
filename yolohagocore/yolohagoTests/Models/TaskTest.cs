using System;
using System.Linq;
using Xunit;
using yolohago.Models;

namespace yolohagoTests.Models
{
    public class TaskTest
    {
        [Fact]
        public void ValidateTaskNameTest()
        {
            var task = Utilities.CreateValidTask();
            Assert.Equal(task.TaskName, "Do this, get paid.");
        }

        [Fact]
        public void ValidateTaskDescriptionTest()
        {
            var task = Utilities.CreateValidTask();
            Assert.Equal(task.Description, "To get paid, this is what you have to do.");
        }

        [Fact]
        public void ValidateTaskKeyTest()
        {
            var task = Utilities.CreateValidTask();
            Guid comparedKey = Guid.NewGuid();
            task.Key = comparedKey;
            Assert.Equal(task.Key, comparedKey);
        }

        [Fact]
        public void ValidateTaskDurationTest()
        {
            var task = Utilities.CreateValidTask();
            Assert.Equal(task.Duration, "00:00:15");
        }

        [Fact]
        public void ValidateTaskPriorityTest()
        {
            var task = Utilities.CreateValidTask();
            Assert.Equal(task.Priority, "High");
        }

        [Fact]
        public void ValidateTaskTypeTest()
        {
            var task = Utilities.CreateValidTask();
            Assert.Equal(task.Type, "Absolute");
        }
        [Fact]
        public void EqualsTaskTest()
        {
            var task1 = Utilities.CreateValidTask();
            var task2 = Utilities.CreateValidTask();
            task2.Key = task1.Key;
            Assert.True(task1.Equals(task2));
        }
        [Fact]
        public void NotEqualsTest()
        {
            var task1 = Utilities.CreateValidTask();
            var task2 = Utilities.CreateValidTask2();
            Assert.False(task1.Equals(task2));
        }
        [Fact]
        public void EqualsNullTest()
        {
            var task1 = Utilities.CreateValidTask();
            Task task2 = null;
            Assert.False(task1.Equals(task2));
        }
        [Fact]
        public void EqualsOtherTypeTest()
        {
            var task1 = Utilities.CreateValidTask();
            var task2 = 7;
            Assert.False(task1.Equals(task2));
        }
        [Fact]
        public void UserToStringTest()
        {
            var task = Utilities.CreateValidTask();
            var comparedText = "Do this, get paid.";
            Assert.Equal(task.ToString(), comparedText);
        }
    }
}


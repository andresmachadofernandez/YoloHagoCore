using System;
using System.Linq;
using Xunit;
using YoloHagoCore.Models;


namespace YoloHagoTests
{
    public class UserTest
    {
        [Fact]
        public void ValidateUsernameTest()
        {
            var user = Utilities.CreateValidUser1();
            Assert.Equal(user.Username, "Username");
        }
        [Fact]
        public void ValidateNameTest()
        {
            var user = Utilities.CreateValidUser1();
            Assert.Equal(user.Name, "Name");
        }
        [Fact]
        public void ValidateLastNameTest()
        {
            var user = Utilities.CreateValidUser1();
            Assert.Equal(user.Lastname, "Lastname");
        }
        [Fact]
        public void ValidatePasswordTest()
        {
            var user = Utilities.CreateValidUser1();
            Assert.Equal(user.Password, "Password");
        }
        [Fact]
        public void ValidateEmailTest()
        {
            var user = Utilities.CreateValidUser1();
            Assert.Equal(user.Email, "email@mock.com");
        }
        [Fact]
        public void ValidateKeyTest()
        {
            var user = Utilities.CreateValidUser1();
            Guid comparedKey = Guid.NewGuid();
            user.Key = comparedKey;
            Assert.Equal(user.Key, comparedKey);
        }
        [Fact]
        public void EqualsTest()
        {
            var user1 = Utilities.CreateValidUser1();
            var user2 = Utilities.CreateValidUser1();
            user2.Key = user1.Key;
            Assert.True(user1.Equals(user2));
        }
        [Fact]
        public void NotEqualsTest()
        {
            var user1 = Utilities.CreateValidUser1();
            var user2 = Utilities.CreateValidUser2();
            Assert.False(user1.Equals(user2));
        }
        [Fact]
        public void EqualsNullTest()
        {
            var user1 = Utilities.CreateValidUser1();
            User user2 = null;
            Assert.False(user1.Equals(user2));
        }
        [Fact]
        public void EqualsOtherTypeTest()
        {
            var user1 = Utilities.CreateValidUser1();
            var user2 = 7;
            Assert.False(user1.Equals(user2));
        }
        [Fact]
        public void UserToStringTest()
        {
            var user1 = Utilities.CreateValidUser1();
            var comparedText = "Username";
            Assert.Equal(user1.ToString(), comparedText);
        }
        [Fact]
        public void UserTaskCollectionEmptyTest()
        {
            var user = Utilities.CreateValidUser1();
            Assert.True(user.TaskCollection.Count == 0);
        }

    }
}


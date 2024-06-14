using Xunit;
using Contacts_Manager;
using System.Numerics;
using System;
namespace ContactManagerTests

{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }


        [Fact]
        public void AddCase()
        {

            // Arrange
            string name = "ali";
            string phone = "0777777777";
           

            // Act
            string result = Program.AddContact(name, phone); ;


            // Assert
            Assert.Equal("The contact has been added successfully.", result);


        }


        [Fact]
        public void Ifexist()
        {

            // Arrange
            Program.AddContact("alia", "07777777");

            // Act
            string result = Program.AddContact("alia", "07777777");

            // Assert
            Assert.Equal("This contact already exists.", result);


        }

        [Fact]
        public void ViewCase()
        {

            // Arrange
            Program.AddContact("Haneen", "07777777");
            Program.AddContact("Aws", "07777777");
            Program.AddContact("Marya", "07777777");
            Program.AddContact("Ahmad", "07777777");
            Program.AddContact("Fatima", "07777777");

            // Act
            Dictionary<string, string> result = Program.ViewAllContacts();

            // Assert
            Assert.Contains(new KeyValuePair<string, string>("haneen", "07777777"), result);
            Assert.Contains(new KeyValuePair<string, string>("aws", "07777777"), result);
            Assert.Contains(new KeyValuePair<string, string>("marya", "07777777"), result);
            Assert.Contains(new KeyValuePair<string, string>("ahmad", "07777777"), result);
            Assert.Contains(new KeyValuePair<string, string>("fatima", "07777777"), result);
        }


        [Fact]
        public void SearchCase()
        {
            

                // Arrange
                Program.AddContact("Lolo", "0777777777");

                // Act
                string contact = Program.SearchContact("Lolo");

                // Assert
                Assert.Equal("Lolo: 0777777777", contact);
            
        }



        [Fact]
        public void RemoveCase()
        {
            // Arrange
            Program.AddContact("Meme", "0777777777");

            // Act
            string result = Program.RemoveContact("Meme");

            // Assert
            Assert.Equal("The contact has been removed successfully.", result);
          
        }
    }
}
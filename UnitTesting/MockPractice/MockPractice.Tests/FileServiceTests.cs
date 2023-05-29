using Moq;

namespace MockPractice.Tests
{
    public class FileServiceTests
    {
        [Fact]
        public void ReadText_WhenCalled_ReturnsAllTextFromFile()
        {
            //Arrange
            //FileService fileService = new FileService();
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(x => x.ReadText()).Returns("Welcome to File Handling");
            var service = new FileService(fileReader.Object);
            //Act
            var result = service.ReadData();
            //Assert
            Assert.Contains("File", result);
               
        }
    }
}
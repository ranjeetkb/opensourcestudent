namespace StudentListTest
{
    public class UnitTest1
    {
        //Testcase for the Controller
        [Fact]
    public void GetStudents_ReturnsOkObjectResult()
    {
        // Arrange
        var studentServiceMock = new Mock<IStudentService>();
        // Assuming _studentService is a property in your controller
        var controller = new YourController(studentServiceMock.Object);
 
        // Act
        var result = controller.GetStudents();
 
        // Assert
        Assert.IsType<OkObjectResult>(result);
    }
    }
}

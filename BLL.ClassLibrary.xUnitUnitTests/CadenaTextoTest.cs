using FluentAssertions;

namespace BLL.ClassLibrary.xUnitUnitTests
{
    public class CadenaTextoTest
    {
        [Fact]
        public void CadenaTest()
        {
            //Arrange
            CadenaTexto objcadena = new CadenaTexto();

            //Act
            var actaul = objcadena.Cadena();


            //Assert
            actaul.Should().StartWith("AB").
                And.EndWith("HI").
                And.Contain("EF").
                And.HaveLength(9);

        }
    }
}
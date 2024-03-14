using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ClassLibrary.xUnitUnitTests
{
    public class ColeccionesTest
    {
        [Fact]

        public void ColeccionTest()
        {
            //arange

            //act
            IEnumerable<int> numbers =new[] {1, 2, 3};   

            //assert
            //Verificar que todos los elementos de una coleccion coincidan con un predicado y que contenga un numero especifico de elementos.
            numbers.Should().OnlyContain(n  => n > 0);
            numbers.Should().HaveCount(3,"Se esperaba 6 valores en la coleccion");
        }
}
    }
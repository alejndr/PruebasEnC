using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Constructor;
using static Constructor.GetterAndSetter;

namespace GetterAndSetterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComprobarNombreCompleto()
        {
            // Arrange
            Person persona = new Person();
            persona.Nombre = "Paco";
            persona.PrimerApellido = "Ramsay";
            persona.SegundoApellido = "Lopez";

            string expected = "Paco, Ramsay Lopez";

            // Act
            string actual = persona.NombreCompleto;

            // Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void ComprobarNombre()
        {
            Person persona = new Person();
            persona.Nombre = "Sally";

            string expected = "Sally";

            Assert.AreEqual(persona.Nombre, expected);
            
        }

        [TestMethod]
        public void ComprobarApellido()
        {
            Person persona = new Person();
            persona.PrimerApellido = "Hender";

            string expected = "Hender";

            Assert.AreEqual(persona.PrimerApellido, expected);

        }
    }
}

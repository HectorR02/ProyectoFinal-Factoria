using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class TiposEmpleadosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            
            Assert.IsTrue(TiposEmpleadosBLL.Insertar(new TiposEmpleados() { TipoEmpleado = "Juans"}));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(TiposEmpleadosBLL.Buscar("Juans"));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(TiposEmpleadosBLL.Eliminar(new TiposEmpleados() { TipoEmpleado = "Juans" }));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(TiposEmpleadosBLL.GetList());
        }
    }
}
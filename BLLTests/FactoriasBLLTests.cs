using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class FactoriasBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsTrue(FactoriasBLL.Insertar(new Entidades.Factorias(487,"sada","asdd",806548)));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(FactoriasBLL.Buscar(487));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(FactoriasBLL.Eliminar(new Entidades.Factorias(487, "sada", "asdd", 806548)));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(FactoriasBLL.GetList());
        }
    }
}